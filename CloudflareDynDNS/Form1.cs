using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using CloudflareDynDNS;
using System.Net;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using System.Threading;
using Microsoft.Win32;
namespace CloudflareDynDNS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        bool error = true, startup;
        string apikey, email, dns, delayTimer, MYIP, DNSRecID, CFStatus, sub, timeout;
        string URL2API = "https://www.cloudflare.com/api_json.html"; // client api
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            UpdateMessage("Wait For First Time Updating Your DNS.", Color.Black);
            try{
                RegistryKey readk = Registry.CurrentUser.CreateSubKey("Software\\CloudFlareDynDNS");
                //start reg read
                apikey = APIKEY.Text = (readk.GetValue("API")!=null) ? readk.GetValue("API").ToString() : "";
                email = Email.Text = (readk.GetValue("Email")!=null) ? readk.GetValue("Email").ToString() : "";
                dns = DNS.Text = (readk.GetValue("DNS")!=null) ? readk.GetValue("DNS").ToString() : "";
                sub = Sub.Text = (readk.GetValue("Sub") != null) ? readk.GetValue("Sub").ToString() : "" ;
                delayTimer = Delay.Text = (readk.GetValue("Delay") != null) ? readk.GetValue("Delay").ToString() : "";
                CFStatus = (readk.GetValue("Status")!=null) ? readk.GetValue("Status").ToString() : "";
                timeout = (Regex.IsMatch("[0]{1,}", readk.GetValue("Timeout").ToString())) ? TimeoutBox.Text = "10" : TimeoutBox.Text = readk.GetValue("Timeout").ToString();
                startup = StartUpBox.Checked = (readk.GetValue("Startup").ToString() == "1") ? true : false;
                CloudFlareStatus.SelectedText = (CFStatus == "1") ? "On" : "Off";
                readk.Close();
                //close reg read

            }
            catch (Exception ex)
            {
                UpdateMessage(ex.Message, Color.Red);
                //MessageBox.Show(ex.Message); // i know you know what that mean :P
            }


            // start first task grabbin domain recored id
            Task GrabingInfo = Task.Factory.StartNew(() =>
            {
                try
                {
                    string GetInfo = Request(URL2API, Convert.ToInt16(timeout), string.Format("a=rec_load_all&tkn={0}&email={1}&z={2}", apikey, email, dns));
                    if (GetInfo != "0")
                    {
                        // prase json output
                        JObject parse = JObject.Parse(GetInfo);
                        if (parse["result"].ToString() == "success")
                        {
                            // get record id
                            DNSID(GetInfo, dns);
                            UpdateMessage("Connection seccessfully ,Grabbing Info", Color.Green);
                            Thread.Sleep(500); // sleep 500MS to view the message
                            RefreshButton(true); // turn on refresh button
                        }
                        else
                        {
                            UpdateMessage(parse["msg"].ToString(), Color.Red);
                            error = false; // there is error
                        }
                    }
                    else {
                            UpdateMessage("Connection Timeout", Color.Red);
                            Thread.Sleep(500);
                            error = false; // there is error
                    }
                }
                catch (WebException ex)
                {
                    UpdateMessage(ex.Message, Color.Red);
                    Thread.Sleep(500);
                }
            });

            // start second task when first ending
            Task UpdaingIP = GrabingInfo.ContinueWith(waiter => {
                // if error is true=no error
                if (error){
                    RefreshButton(false); // turn off refresh button
                    RefreshDNS(); // refresh DNS
                    RefreshButton(true); // turn on refresh button
                }
            });
            // You Only Have 300 Request To Cloudflare API
            int mili2sec = (Convert.ToInt16(delayTimer)*1000)*60;// convert milisecond to minute
            timer1.Interval = (mili2sec == 0) ?  (1*1000*60) /*one minute*/ : mili2sec; // set interval for timer

            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://www.cloudflare.com/my-account.html"; // assign link to linklabel for help
            linkLabel1.Links.Add(link);

        }
        

        // get dns record id
        public void DNSID(string output,string dns){
            // parse input json
            JObject results = JObject.Parse(output);
            int x;
            for (x = 0; x < Convert.ToInt16(results["response"]["recs"]["count"]);x++ ){
                if (Convert.ToString(results["response"]["recs"]["objs"][x]["name"]) == sub+'.'+dns){
                    DNSRecID = results["response"]["recs"]["objs"][x]["rec_id"].ToString();
                }
                
            }
        }

        //Get My IP
        public string myIP() {
            // http://just4ip.herokuapp.com/?ShowSource
            return Request("http://just4ip.herokuapp.com/", Convert.ToInt16(timeout)); // if error return 0
        }
        //web http request method
        public static string Request(string URL,int timeout, string postdata=""){
            try{
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.Method = "POST"; // set method of request
                request.ContentType = "application/x-www-form-urlencoded"; // type of content
                request.ContentLength = postdata.Length; // post data length
                request.Timeout = (timeout*1000); // convert it to seconds
                byte[] post2byte = Encoding.UTF8.GetBytes(postdata);

                Stream dataStream = request.GetRequestStream();
                dataStream.Write(post2byte, 0, post2byte.Length);
                dataStream.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        return reader.ReadToEnd();
                    }
            }catch (Exception){
                return "0"; // return 0 if error
            }
        }

        private void Save_Click(object sender, EventArgs e){
            // save informations to registery
            RegistryKey rk = Registry.CurrentUser.CreateSubKey("Software\\CloudFlareDynDNS");
                rk.SetValue("API", APIKEY.Text);
                rk.SetValue("Email", Email.Text);
                rk.SetValue("DNS", DNS.Text);
                rk.SetValue("Sub", Sub.Text);
                rk.SetValue("Delay", Delay.Text);
                rk.SetValue("Status", (CloudFlareStatus.Text == "On") ? "1" : "0");
                rk.SetValue("Timeout", TimeoutBox.Text);
                rk.SetValue("Startup", (StartUpBox.Checked) ? "1" : "0");
            rk.Close();
            //add 2 startup if checked

            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (StartUpBox.Checked){
                key.SetValue("CloudFlareDynDNS", Application.ExecutablePath); // set value to application full path
            }else{
                key.SetValue("CloudFlareDynDNS", "");//set it empty
            }
            UpdateMessage("The New Configuration will take effect after restart", Color.Brown); // after save info show this
        }
        private void timer1_Tick(object sender, EventArgs e){ // timer interval = delay per minute
            RefreshButton(false); // turn off refresh button on start timer
            Task.Factory.StartNew(() =>{ // new task
                RefreshDNS(); //refresh DNS
                RefreshButton(true);
            });
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            Process.Start(e.Link.LinkData as string); // open link when click on it :P
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshButton(false);
            Task.Factory.StartNew(() =>{ // new task
                RefreshDNS();
                RefreshButton(true);
            });
            
        }
        private void RefreshButton(bool status){
            if (button1.InvokeRequired){
                button1.Invoke(new Action<bool>(RefreshButton), status);// change refresh status from another thread
                return;
            }
            button1.Enabled = status;
        }
        private void UpdateMessage(string input,Color color) {
            this.Invoke((MethodInvoker)(() =>{ // change status label from another thread
                toolStripStatusLabel2.Text = input;
                toolStripStatusLabel2.ForeColor = color;
            }
            ));
        }
        private void RefreshDNS() {
            UpdateMessage("Updating Your IP..", Color.Black);
            MYIP = myIP(); // get the ip
            if (MYIP != "0"){ // if no error
                string RefreshReq = Request(URL2API, Convert.ToInt16(timeout), string.Format("a=rec_edit&tkn={0}&id={1}&email={2}&z={3}&type=A&name={4}&content={5}&service_mode={6}&ttl=1", apikey, DNSRecID, email, dns, sub, MYIP, CFStatus));
                if (RefreshReq != "0") // if no error
                {
                    string msg = "IP "+MYIP+" Updated sccessfully..";
                    string CFErrorMsg  =   CFError(RefreshReq,msg);
                    if (CFErrorMsg == msg){ // if CFerror message equle to msg variable
                        UpdateMessage(msg, Color.Green);
                        return;
                    } else {
                        UpdateMessage(CFErrorMsg, Color.Red);
                        return;
                    }
                }
            }
            UpdateMessage("Connection Timeout", Color.Red);
            return;
        }

        public string CFError(string input,string msg="Done.")
        {
            JObject parse = JObject.Parse(input);
            if (parse["result"].ToString() == "success")
            {
                return msg;
            }
            return parse["msg"].ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void Form1_Resize(object sender, EventArgs e){
            //https://www.iconfinder.com/icons/82477/available_updates_icon#size=26
            if(WindowState == FormWindowState.Minimized){
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(3500);
                Hide();
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e){
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            Show();
        }
        private void button2_Click(object sender, EventArgs e){
            TimeoutBox.Text = "15";
            Delay.Text = "1";
            StartUpBox.Checked = false;
            CloudFlareStatus.TabIndex = 0;
        }
    }
}
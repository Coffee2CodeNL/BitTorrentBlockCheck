using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters;
using System.Diagnostics;

namespace TorrentBlockCheck
{
    public partial class MainForm : Form
    {
        private string locatie;
        private Dictionary<string,object> results = new Dictionary<string, object>();
        private StringBuilder traceresults = new StringBuilder();
        private int cmdcount = 0;
        private bool reportsent = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmdcount = 0;
            backgroundWorker1.RunWorkerAsync();
            button1.Enabled = false;
            timer1.Enabled = true;
            timer1.Start();
            reportsent = false;
        }

        private void DoOnUIThread(MethodInvoker d)
        {
            if (this.InvokeRequired) { this.Invoke(d); } else { d(); }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                WebClient wc = new WebClient();
                wc.Proxy = null;
                var ipjson = wc.DownloadString("http://ipinfo.io/json");
                JObject ipdata = JObject.Parse(ipjson);
                if((string)ipdata.SelectToken("country") != "NL")
                {
                    MessageBox.Show("You are not a Dutch resident.\r\nYou cannot use this application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                if ((string)ipdata.SelectToken("city") == null)
                {
                    DoOnUIThread(delegate()
                    {
                        LocatieDialog ld = new LocatieDialog();
                        if (ld.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                        {
                            locatie = ld.textBox1.Text;
                        }
                        else
                        {
                            locatie = "NULL";
                        }
                    });
                }
                else
                {
                    locatie = (string)ipdata.SelectToken("city");
                }
                var ip = (string)ipdata.SelectToken("ip");
                var isp = (string)ipdata.SelectToken("org");
                lblIP.Invoke((MethodInvoker)delegate { lblIP.Text = ip; });
                lblISP.Invoke((MethodInvoker)delegate { lblISP.Text = isp; });
                lblLocatie.Invoke((MethodInvoker)delegate { lblLocatie.Text = locatie; });
                results["ip"] = ip; 
                results["isp"] = isp;
                results["locatie"] = locatie;
                #region OBTTrackerCheck
                // OpenBitTorrent Tracker Check
                Task OpenBTTask = new Task(() =>
                {
                    bool result = checkTracker("tracker.openbittorrent.com", 80);
                    if (result)
                    {
                        pbOpenBTUDP.Image = Properties.Resources.accept;
                        results["openbittorrent"] = 1;
                    }
                    else
                    {
                        pbOpenBTUDP.Image = Properties.Resources.exclamation;
                        results["openbittorrent"] = 0;
                    }
                });
                OpenBTTask.Start();
                #endregion
                #region PBTTrackerCheck
                // PublicBT Tracker Check
                Task PublicBTTask = new Task(() =>
                {
                    bool result = checkTracker("tracker.publicbt.com", 80);
                    if (result)
                    {
                        pbPublicBTUDP.Image = Properties.Resources.accept;
                        results["publicbt"] = 1;
                    }
                    else
                    {
                        pbPublicBTUDP.Image = Properties.Resources.exclamation;
                        results["publicbt"] = 0;
                    }
                });
                PublicBTTask.Start();
                #endregion
                #region iSITTrackerCheck
                // iStoleIT Tracker Check
                Task iStoleITTask = new Task(() =>
                {
                    bool result = checkTracker("tracker.istole.it", 6969);
                    if (result)
                    {
                        pbiStoleITUDP.Image = Properties.Resources.accept;
                        results["istoleit"] = 1;
                    }
                    else
                    {
                        pbiStoleITUDP.Image = Properties.Resources.exclamation;
                        results["istoleit"] = 0;
                    }
                });
                iStoleITTask.Start();
                #endregion
                #region CCCTrackerCheck
                // CCC Tracker Check
                Task CCCTask = new Task(() =>
                {
                    bool result = checkTracker("tracker.ccc.de", 80);
                    if (result)
                    {
                        pbCCCUDP.Image = Properties.Resources.accept;
                        results["ccc"] = 1;
                    }
                    else
                    {
                        pbCCCUDP.Image = Properties.Resources.exclamation;
                        results["ccc"] = 0;
                    }
                });
                CCCTask.Start();
                #endregion
                #region DemonoidTrackerCheck
                // Demonoid Tracker Check
                Task DemoniiTask = new Task(() =>
                {
                    bool result = checkTracker("open.demonii.com", 1337);
                    if (result)
                    {
                        pbDemoniiUDP.Image = Properties.Resources.accept;
                        results["demonoid"] = 1;
                    }
                    else
                    {
                        pbDemoniiUDP.Image = Properties.Resources.exclamation;
                        results["demonoid"] = 0;
                    }
                });
                DemoniiTask.Start();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden tijdens het ophalen van de IP Informatie.\r\nProbeer het alstublieft opnieuw", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Invoke((MethodInvoker)delegate { button1.Enabled = true; });
            }
        }

        private bool checkTracker(string tracker,int port)
        {
                try
                {
                    Task TraceRoute = new Task(() => 
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                        startInfo.UseShellExecute = false;
                        startInfo.RedirectStandardOutput = true;
                        startInfo.CreateNoWindow = true;
                        startInfo.FileName = "cmd.exe";
                        startInfo.Arguments = "/C tracert " + tracker;
                        process.StartInfo = startInfo;
                        process.Start();
                        string tracert = process.StandardOutput.ReadToEnd();
                        process.WaitForExit();
                        traceresults.Append(cmdcount + ":[").Append(tracker).Append("]").Append(Environment.NewLine);
                        traceresults.Append(cmdcount + ":[").Append(tracert).Append("]").Append(Environment.NewLine);
                        cmdcount++;
                    });
                    TraceRoute.Start();
                    Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    client.Connect(tracker, port);
                    byte[] conPacket = new byte[16];
                    byte[] temp = BitConverter.GetBytes(0x41727101980).Reverse().ToArray();
                    byte[] temp2 = BitConverter.GetBytes(0);
                    byte[] temp3 = BitConverter.GetBytes(new Random().Next(0, 65535));
                    Array.Copy(temp, 0, conPacket, 0, 8);
                    Array.Copy(temp2, 0, conPacket, 8, 4);
                    Array.Copy(temp3, 0, conPacket, 12, 4);
                    //Connect to the protocol
                    client.Send(conPacket);
                    byte[] response = new byte[16];
                    client.Receive(response);
                    byte[] resptemp1 = new byte[4];
                    Array.Copy(response, 4, resptemp1, 0, 4);
                    client.Close();
                    if (resptemp1.Intersect(temp3).Any())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (SocketException ex)
                {
                    if (ex.SocketErrorCode == SocketError.ConnectionReset)
                    {
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Error: " + ex.SocketErrorCode);
                        return false;
                    }
                }            
        }

        private void sendResults()
        {
            try
            {
                //Pas de URL aan naar het juiste adres.
                httpWebRequest = (HttpWebRequest)WebRequest.Create("http://blockcheck.dead-pixel.nl/api.php");
                httpWebRequest.Proxy = null;
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(DTJ(results));
                    streamWriter.Flush();
                    streamWriter.Close();

                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        if (result == "1")
                        {
                            MessageBox.Show("Rapport Verstuurd!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button1.Enabled = true;
                            
                        }
                        else
                        {
                            MessageBox.Show("Er is een fout opgetreden tijdens het versturen van het Rapport.\r\nProbeer het alstublieft opnieuw", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            button1.Enabled = true;
                            
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Er is een fout opgetreden tijdens het versturen van het Rapport.\r\nProbeer het alstublieft opnieuw", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Enabled = true;
               
            }
            
        }

        string DTJ(Dictionary<string,object> dict)
        {
            string json = JsonConvert.SerializeObject(dict, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.None,
                TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple
            });
            return json;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = cmdcount;
            if(cmdcount == 5)
            {
                if (checkBox1.Checked == false)
                {
                    if (!reportsent)
                    {
                        string tracert = traceresults.ToString();
                        byte[] bytes = new byte[tracert.Length * sizeof(char)];
                        System.Buffer.BlockCopy(tracert.ToCharArray(), 0, bytes, 0, bytes.Length);
                        string enctrace = Convert.ToBase64String(bytes);
                        results["traces"] = enctrace;
                        timer1.Enabled = false;
                        timer1.Stop();
                        reportsent = true;
                        sendResults();
                    }
                }
                else if (checkBox1.Checked == true)
                {
                    MessageBox.Show("Tests Afgerond!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1.Enabled = true;
                    timer1.Stop();
                    timer1.Enabled = false;
                }
            }
        }
    }
}

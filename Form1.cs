using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace MonolithConect
{
    public partial class MonolithConect : Form
    {
        private bool auto = false;
        private DataTable dt = new DataTable();
        static string date = DateTime.Now.ToString("yyyy-MM-dd");
        private int counter = 0;
        private int refreshTime;
        private string url;
        private string port;
        private string DesURL = "";
        private string requestXml = "<soap:Envelope xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\n" +
    "<soap:Header>\n" +
    "<HTNGHeader xmlns = \"http://htng.org/1.1/Header/\" >\n" +
    "<EX_HOTEL>\n" +
       " <login>\n" +
           "<username>p1</username>\n" +
           "<password>p1</password>\n" +
        "</login>\n" +
    "</EX_HOTEL>\n" +
    "</HTNGHeader>\n" +
    "</soap:Header>\n" +
    "<soap:Body>\n" +
    "<GET_EXT_INHOUSE>\n" +
       "<Query_Date>"+ date + "</Query_Date>\n" +
    "</GET_EXT_INHOUSE>\n" +
    "</soap:Body>\n" +
"</soap:Envelope>\n";


        public MonolithConect()
        {
            InitializeComponent();
            InitializeTimer();
            

        }

        public string postXMLData(string destinationUrl, string requestXml)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(destinationUrl);
                byte[] bytes;
                bytes = System.Text.Encoding.ASCII.GetBytes(requestXml);
                request.Timeout = -1;
                request.ContentType = "text/xml; encoding='utf-8'";
                request.ContentLength = bytes.Length;
                request.Method = "POST";
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                HttpWebResponse response;
                response = (HttpWebResponse)request.GetResponse();
                requestStream.Close();
                Log(true);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream responseStream = response.GetResponseStream();
                    string responseStr =  new StreamReader(responseStream).ReadToEnd();
                    string responseFinal = responseStr.Replace("\0\r", "");
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"\\192.168.200.95\htdocs\ex_hotel\data.xml")))
                    {
                        outputFile.WriteLine(responseFinal);
                    }
                    Log(false);
                    return responseFinal;
                }
                else
                {
                    Log(false);
                    return response.StatusCode.ToString();
                }
                
            }
            catch (HttpRequestException e)
            {
                //Console.WriteLine("\nException Caught!");
                //Console.WriteLine("Message :{0} ", e.Message);
            }catch (WebException ex)
            {
                Console.WriteLine("Message :{0} ", ex.Message);
                errorLog();
            }

            return null;
        }

        private bool AcceptAllCertifications(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        private void errorLog()
        {
            DataRow row = dt.NewRow();

            row["Fecha"] = date;
            row["Hora"] = DateTime.Now.ToString("HH:mm:ss"); ;
            row["Descripcion"] = "Request Fail";
            dt.Rows.Add(row);
            textBoxRequest.Text = "Error inesperado por favor revise su coneccion a internet o la sentencia del request";

        }

        private void Log(bool i)
        {
            if (i)
            {

                DataRow row = dt.NewRow();
                row["Fecha"] = date;
                row["Hora"] = DateTime.Now.ToString("HH:mm:ss"); ;
                row["Descripcion"] = "Request Send";
                dt.Rows.Add(row);
                textBoxRequest.Text = ExtractQuery();//requestXml;
            }
            else if(!i)
            {
                DataRow row = dt.NewRow();

                row["Fecha"] = date;
                row["Hora"] = DateTime.Now.ToString("HH:mm:ss"); ;
                row["Descripcion"] = "Response received";
                dt.Rows.Add(row);
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(@"\\192.168.200.95\htdocs\ex_hotel\data.xml");
                dataGridResponse.DataSource = dataSet.Tables[0];
            }

        }

        private string ExtractQuery()
        {
            string query = "";
            bool xml = false;
            string[] request = requestXml.Split('\n');
            foreach (var line in request)
            {
                if (line.ToString().Contains("<soap:Body>"))
                {
                    xml = !xml;
                }
                else if (line.ToString().Contains("</soap:Body>"))
                {
                    xml = !xml;
                }
                if (xml && !line.ToString().Contains("soap:Body"))
                {
                    query += line.ToString()+"\n\n";
                }
            }
            return query;
        }

        private void InitializeTimer()
        {
            // Run this procedure in an appropriate event.  
            counter = 0;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            // Hook up timer's tick event handler.  
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);

        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            if (counter == refreshTime)
            {
                if (auto)
                {
                counter = 0;
                //label1.Text = counter.ToString();
                date = DateTime.Now.ToString("yyyy-MM-dd");
                hacerPost();
                }
                else
                {
                   counter = 0;
                }
            }
            else
            {
                if (counter > refreshTime)
                {
                    counter = 0;
                }
                counter = counter + 1;
                label1.Text = "Procedures Run: " + counter.ToString();
                
            }
        }

        private string minutos(int refresh)
        {
            double minutos;
            if (refresh / 60 > 0)
            {
                minutos = (refresh / 60);
                return minutos.ToString() + " Minutes";

            }
            else
            {
                minutos = refresh;
                return minutos.ToString() + " Seconds";
            }

        }

        private void MonolithConect_Load(object sender, EventArgs e)
        {
            
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Hora");
            dt.Columns.Add("Descripcion");
            dataGridLog.DataSource = dt;
            hacerPost();
            //textBoxRefresh.Text = "Refresh Time: " + minutos(refreshTime);
        }

        private void loadIPPort()
        {
            string ip = System.IO.File.ReadAllText("ip.txt");
            string puerto = System.IO.File.ReadAllText("port.txt");
            string refresh = System.IO.File.ReadAllText("refreshTime.txt");
            url = ip;
            port = puerto;
            refreshTime = Int32.Parse(refresh);
        }

        private void hacerPost()
        {
            loadIPPort();
            DesURL = "http://"+url+":"+port+"/";
            DesURL = DesURL.Replace("\r\n" , "");
            if (DesURL != "http://:/" && DesURL != "")
            {
                postXMLData(DesURL, requestXml);
            }
            else
            {
                textBoxRequest.Text = "Por Favor Introdusca una IP y un Puerto para hacer las consultas";
            }
        }

        private void iPyPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IpSetUp frm = new IpSetUp();
            frm.ShowDialog();
            hacerPost();
        }

        private void refreshTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshTime frm = new RefreshTime();
            frm.ShowDialog();
            string refresh = System.IO.File.ReadAllText("refreshTime.txt");
            refreshTime = Int32.Parse(refresh);
            //textBoxRefresh.Text = "Refresh Time: " + minutos(refreshTime);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            hacerPost();
            System.Windows.Forms.MessageBox.Show("La disponibilidad en la aplicacion fue actualizada");
        }

        private void pruevasAutomaticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (auto)
            {
                auto = false;
            }
            else
            {
                auto = true;
            }
        }
    }
}

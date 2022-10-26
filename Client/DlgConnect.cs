using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;


namespace Client
{
    public partial class DlgConnect : Form
    {
        public int Port;
        public string Address;
        public bool CanEditPort;
        IPAddress ip = null;
        public Socket sok { get; private set; }
        public DlgConnect()
        {
            InitializeComponent();
           
            this.Load += DlgConnect_Load;
            sok = null;
            UI_Btn_connect.Click += UI_Btn_connect_Click;
        }

        private void UI_Btn_connect_Click(object sender, EventArgs e)
        {
            if (sok != null)
                return;
            if (UI_tBox_hAddress.Text.Length < 1)
                return;

            if(IPAddress.TryParse(UI_tBox_hAddress.Text,out ip))
            {

                try
                {
                    BeginConnects();
                    Text = "connected";
                }
                catch(Exception ex)
                {
                    // error message and set communication socket to null
                    sok = null;
                    MessageBox.Show(ex.Message, "Connection Failed");
                }
            }
            else
            {
                UI_tBox_hAddress.Focus();
                UI_lbl_status.Text = "Not connected";
                sok = null;
            }
        }
        private void BeginConnects()
        {
            sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try 
            {
                // start connecting with target ip address and port 1666
                sok.BeginConnect(ip, 1666, cbConnect, sok);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Begin Connect Error: {ex.Message} ");
                MessageBox.Show($"Begin Connect Error: {ex.Message} ");
                
            }
        }
        private void cbConnect(IAsyncResult ar)
        {
            Socket temp = (Socket)ar.AsyncState;
           // sok = ar.AsyncState as Socket;
            try
            {
                temp.EndConnect(ar);
               // sok.EndConnect(ar);
                DialogResult = DialogResult.OK;
                MessageBox.Show("success");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                temp.Close();
            }
        }

        private void DlgConnect_Load(object sender, EventArgs e)
        {
            //port text is 80 port textbox is disabled
            UI_tBox_hPort.Text = Port.ToString();
            UI_tBox_hPort.Enabled = CanEditPort;
            //address textbox
            UI_tBox_hAddress.Text = Address;
        }
    }
}

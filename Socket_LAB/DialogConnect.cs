using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMPE2800_SocketGuess_Frames;
using System.Net;
using System.Net.Sockets;



namespace Socket_LAB
{
    public partial class DialogConnect : Form
    {
        // SocketGuess sg = new SocketGuess();

        public Socket _cSock = null;
        public Socket _lSock = null;


        
        public DialogConnect()
        {
            InitializeComponent();
            UI_Btn_connect.Click += UI_Btn_connect_Click;
        }

        private void UI_Btn_connect_Click(object sender, EventArgs e)
        {
        
        }
    }
}

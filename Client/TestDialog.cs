using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using CMPE2800_SocketGuess_Frames;
using System.Threading;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Client
{
    public partial class TestDialog : Form
    {
        // connection socket
        private Socket sok;

        // thread to receive bytes from connection
        private Thread process;
        private delegate void DelVoidVoid();
        public TestDialog()
        {
            InitializeComponent();
     
            Init();
            UI_btn_connect.Click += UI_btn_connect_Click;
            UI_NumGuessBar.ValueChanged += UI_NumGuessBar_ValueChanged;
            UI_btn_guess.Click += UI_btn_guess_Click;
           



        }
        private void Init()
        {
            UI_btn_connect.Text = "Connect";
            UI_btn_guess.Text = "Guess";
            UI_NumGuessBar.Maximum = 1000;
            UI_NumGuessBar.Minimum = 1;
            UI_NumGuessBar.Value = 500;
            UI_NumGuessBar.TickFrequency = 100;
            UI_btn_guess.Enabled = false;
            UI_NumGuessBar.Enabled = false;
        }

        private void UI_btn_guess_Click(object sender, EventArgs e)
        {
            SocketGuess sg = new SocketGuess(UI_NumGuessBar.Value);
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            //CMPE2800_SocketGuess_Frames.
            try
            {
                bf.Serialize(ms, sg);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Serialize! button guess : {ex.Message}");
            }
            try
            {
                sok.Send(ms.GetBuffer(), (int)ms.Length, SocketFlags.None);

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Serialize! send buffer button guess : {ex.Message}");
            }
           
        }
        private void ReceiveDate()
        {
            // buffer byte array
            byte[] buff = new byte[2000];

            // ensure that receive calls won't timeout
            sok.ReceiveTimeout = 0;

            while (true)
            {
                int iByte = 0;

                try
                {
                    // block on receive - will throw on hard disco
                    iByte = sok.Receive(buff);
                }
                catch (Exception err)
                {
                    // error message
                    MessageBox.Show(err.Message);
                    return;
                }

                // detect soft disco
                if (iByte.Equals(0))
                {
                    // error message
                    MessageBox.Show("Connection lost");
                    return;
                }

                // deserialize the data retrieve from server
                BinaryFormatter bf = new BinaryFormatter();
                SocketReplyIncorrect spi = (SocketReplyIncorrect)bf.Deserialize(new MemoryStream(buff));
        

                switch (spi._reply)
                {
                    // if guess is correct
                    case SocketReplyIncorrect.eReplyType.eTooLow:


                        // show appropriate message
                        MessageBox.Show("Too Low!");

                        // change the range and label
                        Invoke(new DelVoidVoid(Higher));
                        break;

                  
                    // if guess is higher
                    case SocketReplyIncorrect.eReplyType.eTooHigh:

                        // show appropriate message
                        MessageBox.Show("Too high");

                        // change the range and label
                        Invoke(new DelVoidVoid(Lower));
                        break;

                    default:
                        // show appropriate message
                        MessageBox.Show("Correct!");
                        Invoke(new DelVoidVoid(Init));

                        // restart the game
                      //  Invoke(new DelVoidVoid(Init));
                        break;
                }

            }
            }
   
        private void Higher()
        {
            UI_NumGuessBar.Minimum = UI_NumGuessBar.Value + 1;

            UI_lbl_max.Text = UI_NumGuessBar.Value.ToString();
            UI_lbl_value.Text = UI_NumGuessBar.Value.ToString();

            //  lb_select.Text = tbr_guessNum.Value.ToString();
        }
        private void Lower()
        {
            UI_NumGuessBar.Minimum = UI_NumGuessBar.Value + 1;

            UI_lbl_min.Text = UI_NumGuessBar.Value.ToString();
            UI_lbl_value.Text = UI_NumGuessBar.Value.ToString();
        }

    
        private void UI_NumGuessBar_ValueChanged(object sender, EventArgs e)
        {
            UI_lbl_value.Text = UI_NumGuessBar.Value.ToString();
        }

        private void UI_btn_connect_Click(object sender, EventArgs e)
        {
            DlgConnect dlg = new DlgConnect();
            dlg.Port = 1666;
            dlg.Address = "";
            dlg.CanEditPort = true;
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                sok = dlg.sok;
                /*       Console.WriteLine($"From user: {dlg.Address} : {dlg.Port}");
                       Console.WriteLine($"Conected to {dlg.sok.RemoteEndPoint}!");
                       Text = "Conneceted!! " + dlg.sok.RemoteEndPoint.ToString();*/
                process = new Thread(ReceiveDate);
                process.IsBackground = true;
                process.Start();

                UI_btn_guess.Enabled = true;
                UI_NumGuessBar.Enabled = true;
           
                
            }

        }
    }
}

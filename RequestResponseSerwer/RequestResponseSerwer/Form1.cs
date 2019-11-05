using NetMQ;
using NetMQ.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestResponseSerwer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Task t = Task.Run(() => nasluchuj());
        }

        void nasluchuj()
        {
            using (ResponseSocket rs = new ResponseSocket("@tcp://*:5555"))
            {
                while (true)
                {
                    string odp = rs.ReceiveFrameString();
                    switch (odp)
                    {
                        case "data":
                            rs.SendFrame(DateTime.Now.ToString("yyyy-MM-dd"));
                            break;
                        case "czas":
                            rs.SendFrame(DateTime.Now.ToString("hh:mm:ss"));
                            break;
                    }
                    MethodInvoker mi = () => wypiszLog(odp);
                    Invoke(mi);
                }
            }
        }

        void wypiszLog(string wiadomosc)
        {
            switch (wiadomosc)
            {
                case "data":
                    logi.Items.Add(DateTime.Now.ToString() + " - Odebrano prośbę o datę");
                    break;
                case "czas":
                    logi.Items.Add(DateTime.Now.ToString() + " - Odebrano prośbę o czas");
                    break;
            }
        }
    }
}

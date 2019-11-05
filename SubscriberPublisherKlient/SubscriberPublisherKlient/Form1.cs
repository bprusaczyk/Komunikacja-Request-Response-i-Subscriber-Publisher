using NetMQ;
using NetMQ.Sockets;
using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubscriberPublisherKlient
{
    public partial class Form1 : Form
    {
        bool subskrypcja;
        string temat;

        public Form1()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            ipSerweraGrupa.Enabled = false;
            subskrybujGrupa.Enabled = true;
        }

        private void start_Click(object sender, EventArgs e)
        {
            start.Enabled = false;
            stop.Enabled = true;
            subskrypcja = true;
            temat = tematWybor.Text.ToString();
            tematWybor.Enabled = false;
            Task t = Task.Run(() => subskrybuj());
        }

        void subskrybuj()
        {
            using (SubscriberSocket ss=new SubscriberSocket())
            {
                try
                {
                    ss.Connect("tcp://" + ipSerwera.Text + ":12345");
                }
                catch (SocketException se)
                {
                    MessageBox.Show(se.Message);
                    MethodInvoker mi = new MethodInvoker(() =>
                    {
                        ipSerweraGrupa.Enabled = true;
                        subskrybujGrupa.Enabled = false;
                        start.Enabled = true;
                        stop.Enabled = false;
                        subskrypcja = false;
                        tematWybor.Enabled = true;
                    });
                    Invoke(mi);
                }
                switch (temat)
                {
                    case "datę":
                        ss.Subscribe("data");
                        break;
                    case "czas":
                        ss.Subscribe("czas");
                        break;
                    case "datę i czas":
                        ss.Subscribe(string.Empty);
                        break;
                    default:
                        break;
                }
                while (subskrypcja)
                {
                    string temat = ss.ReceiveFrameString();
                    string odp = ss.ReceiveFrameString();
                    MethodInvoker mi = new MethodInvoker(() => wypiszLogi(odp, temat));
                    Invoke(mi);
                }
            }
        }

        void wypiszLogi(string odp, string temat)
        {
            logi.Items.Add(DateTime.Now.ToString() + " - odebrano wiadomość z tematu \"" + temat + "\" o treści: " + odp);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            stop.Enabled = false;
            start.Enabled = true;
            subskrypcja = false;
            tematWybor.Enabled = true;
        }
    }
}

using NetMQ;
using NetMQ.Sockets;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubscriberPublisherSerwer
{
    public partial class Form1 : Form
    {
        Task t;

        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            start.Enabled = false;
            t = Task.Run(() => publikuj());
        }

        void publikuj()
        {
            using (PublisherSocket ps = new PublisherSocket())
            {
                ps.Bind("tcp://*:12345");
                while (true)
                {
                    if (date.Checked)
                    {
                        string odp = DateTime.Now.ToString("yyyy-MM-dd");
                        ps.SendMoreFrame("data").SendFrame(odp);
                        MethodInvoker mi = new MethodInvoker(() => wypiszLogi(Temat.Data, odp));
                        Invoke(mi);
                    }
                    if (czas.Checked)
                    {
                        string odp = DateTime.Now.ToString("HH:mm:ss");
                        ps.SendMoreFrame("czas").SendFrame(odp);
                        MethodInvoker mi = new MethodInvoker(() => wypiszLogi(Temat.Czas, odp));
                        Invoke(mi);
                    }
                    try
                    {
                        Thread.Sleep(int.Parse(interwal.Text) * 1000);
                    }
                    catch (FormatException fe)
                    {
                        MessageBox.Show(fe.Message);
                        MethodInvoker mi = new MethodInvoker(() => interwal.Text = "10");
                        Invoke(mi);
                    }
                }
            }
        }

        void wypiszLogi(Temat t, string odp)
        {
            string tresc = null;
            switch (t)
            {
                case Temat.Data:
                    tresc = "Publikuję temat \"data\" o treści " + odp;
                    break;
                case Temat.Czas:
                    tresc = "Publikuję temat \"czas\" o treści " + odp;
                    break;
            }
            logi.Items.Add(DateTime.Now + " - " + tresc);
        }
    }

    public enum Temat
    {
        Data, Czas
    }
}

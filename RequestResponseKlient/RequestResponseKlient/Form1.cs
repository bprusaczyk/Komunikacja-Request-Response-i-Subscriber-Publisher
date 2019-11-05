using NetMQ;
using NetMQ.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestResponseKlient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pobierzTeraz_Click(object sender, EventArgs e)
        {
            pobierzDane();
        }

        void pobierzDane()
        {
            try
            {
                if (date.Checked)
                {
                    using (RequestSocket rs = new RequestSocket(">tcp://" + ipSerwera.Text + ":5555"))
                    {
                        rs.SendFrame("data");
                        logi.Items.Add(DateTime.Now.ToString() + " - wysłano zapytanie o datę");
                        DateTime dt = DateTime.Parse(rs.ReceiveFrameString());
                        logi.Items.Add(DateTime.Now.ToString() + " - odebrano datę z serwera: " + dt.ToString("yyyy-MM-dd"));
                    }
                }
                if (czas.Checked)
                {
                    using (RequestSocket rs = new RequestSocket(">tcp://" + ipSerwera.Text + ":5555"))
                    {
                        rs.SendFrame("czas");
                        logi.Items.Add(DateTime.Now.ToString() + " - wysłano zapytanie o czas");
                        TimeSpan ts = TimeSpan.Parse(rs.ReceiveFrameString());
                        logi.Items.Add(DateTime.Now.ToString() + " - odebrano czas z serwera: " + ts.ToString());
                    }
                }
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
                ipSerweraGrupa.Enabled = true;
                pobierzGrupa.Enabled = false;
            }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            pobierzDane();
        }

        private void pobierajCo_CheckedChanged(object sender, EventArgs e)
        {
            if (pobierajCo.Checked)
            {
                try
                {
                    timer.Interval = Int32.Parse(coIle.Text) * 1000;
                    timer.Start();
                }
                catch (FormatException fe)
                {
                    MessageBox.Show(fe.Message);
                    pobierajCo.Checked = false;
                }
            }
            else
            {
                timer.Stop();
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            ipSerweraGrupa.Enabled = false;
            pobierzGrupa.Enabled = true;
        }

        private void coIle_TextChanged(object sender, EventArgs e)
        {
            timer.Interval = Int32.Parse(coIle.Text) * 1000;
        }
    }
}

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

namespace Port_Scanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            short[] ListaPortow = { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

            string host = textBox1.Text;
            listBox1.Items.Add($"Skanowanie portów dla {host}");
            listBox1.Items.Add("To może chwilę potrwać...");
            foreach (short port in ListaPortow)
            {
                this.Refresh();
                try
                {
                    TcpClient client = new TcpClient(host, port);
                    listBox1.Items.Add($"Port: {port.ToString()} jest otwarty");
                }
                catch
                {
                    listBox1.Items.Add($"Port {port.ToString()} jest zamknięty!");
                }
            }
        }
    }
}

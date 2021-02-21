using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockClient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            ServiceReference1.Stock s = proxy.GetStock(Form1.Id);
            label1.Text = s.Symbol;
            label2.Text = s.Name;
            pictureBox1.ImageLocation = s.Logo;
            label7.Text = ":    " + s.Ceo;
            label8.Text = ":    " + s.Hq_address;
            label9.Text = ":    " + s.Country;
            label15.Text = ":   " + s.Marketcap;
            label19.Text = ":   " + s.Employees;
            label10.Text = s.Sector;
            label11.Text = s.Industry;
            label12.Text = "traded on " + s.Exchange.ToUpper() + " & listed at " + s.Listdate;
            label13.Text = ":   " + s.Phone;
            label17.Text = ":   " + s.Url;
            richTextBox1.Text = s.Description;
            proxy.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

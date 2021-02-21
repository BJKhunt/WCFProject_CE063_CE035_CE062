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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if(Form1.isCreate)
            {
                label1.Text = "CREATE";
                button1.Text = "Submit";
            }
            else
            {
                label1.Text = "UPDATE";
                button1.Text = "Update";
                ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
                ServiceReference1.Stock s = proxy.GetStock(Form1.Id);
                textBox1.Text = s.Symbol;
                textBox2.Text = s.Name;
                textBox3.Text = s.Exchange;
                textBox4.Text = s.Ceo;
                textBox5.Text = s.Hq_address;
                textBox6.Text = s.Country;
                textBox7.Text = s.Logo;
                textBox8.Text =  s.Marketcap;
                textBox9.Text =  s.Employees;
                textBox11.Text = s.Sector;
                textBox12.Text = s.Industry;
                textBox13.Text = s.Phone;
                textBox14.Text =  s.Url;
                richTextBox1.Text = s.Description;
                proxy.Close();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Form1.isCreate)
            {
                ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
                ServiceReference1.Stock s = new ServiceReference1.Stock();
                s.Symbol = textBox1.Text;
                s.Name = textBox2.Text;
                s.Exchange = textBox3.Text;
                s.Ceo = textBox4.Text;
                s.Hq_address = textBox5.Text;
                s.Country = textBox6.Text;
                s.Logo = textBox7.Text;
                s.Marketcap = textBox8.Text;
                s.Employees = textBox9.Text;
                s.Sector = textBox11.Text;
                s.Industry = textBox12.Text;
                s.Phone = textBox13.Text;
                s.Url = textBox14.Text;
                s.Description = richTextBox1.Text;
                s.Id = Form1.Id;
                s.Listdate = monthCalendar1.SelectionRange.Start.ToShortDateString();
                bool flag = proxy.AddStock(s);
                proxy.Close();
                if(flag)
                    this.Close();
            }
            else
            {
                ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
                ServiceReference1.Stock s = new ServiceReference1.Stock();
                s.Symbol = textBox1.Text;
                s.Name = textBox2.Text;
                s.Exchange = textBox3.Text;
                s.Ceo = textBox4.Text;
                s.Hq_address = textBox5.Text;
                s.Country = textBox6.Text;
                s.Logo = textBox7.Text;
                s.Marketcap = textBox8.Text;
                s.Employees = textBox9.Text;
                s.Sector = textBox11.Text;
                s.Industry = textBox12.Text;
                s.Phone = textBox13.Text;
                s.Url = textBox14.Text;
                s.Description = richTextBox1.Text;
                s.Id = Form1.Id;
                s.Listdate = monthCalendar1.SelectionRange.Start.ToShortDateString();
                bool flag = proxy.updateStock(s,s.Id);
                proxy.Close();
                if(flag)
                    this.Close();
            }
        }
    }
}

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
    public partial class Form1 : Form
    {
        public static int Id;
        public static Boolean isCreate;
        public Form1()
        {
            InitializeComponent();
 //           listcollection.Clear();
//            DataSet ds = proxy.GetStocks();

        }
  //      List<string> listcollection = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //listBox1.DisplayMember = "Select anyone to do operation";
            //listBox1.ValueMember = "-1"
            callMe();
        }

        private void callMe()
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            DataSet ds = proxy.GetStocks();
            listBox1.DataSource = ds.Tables[0].DefaultView;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";
            proxy.Close();
        }
        private void View_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Id = Convert.ToInt32(listBox1.GetItemText(listBox1.SelectedValue));
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isCreate = true;
            Form3 f3 = new Form3();
            f3.ShowDialog();
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            DataSet ds = proxy.GetStocks();
            listBox1.DataSource = ds.Tables[0].DefaultView;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";
            proxy.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isCreate = false;
            Id = Convert.ToInt32(listBox1.GetItemText(listBox1.SelectedValue));
            Form3 f4 = new Form3();
            f4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            Id = Convert.ToInt32(listBox1.GetItemText(listBox1.SelectedValue));
            bool flag = proxy.DeleteStock(Id);
            proxy.Close();
            callMe();
        }
        /*
private void textBox1_TextChanged(object sender, EventArgs e)
{
if(string.IsNullOrEmpty(textBox1.Text)==false)
{
foreach(string str in listcollection)
{
if(str.StartsWith(textBox1.Text))
{
listBox1.Items.Add(str);
}
}
}
else if(textBox1.Text=="")
{
foreach(string str in listcollection)
{
listBox1.Items.Add(str);
}
}
}*/

    }
}

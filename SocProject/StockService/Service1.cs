using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

//Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Brijesh\source\repos\SocProject\StockService\Database1.mdf;Integrated Security=True;Connect Timeout=30
namespace StockService
{
    public class Service1 : IService1
    {
        public bool AddStock(Stock s)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Brijesh\source\repos\SocProject\StockService\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Stock(logo,listdate,country,industry,sector,marketcap,employees,phone,ceo,url,description,exchange,name,symbol,hq_address) values(@logo,@listdate,@country,@industry,@sector,@marketcap,@employees,@phone,@ceo,@url,@description,@exchange,@name,@symbol,@hq_address)", con);
            cmd.Parameters.AddWithValue("@logo", s.Logo);
            cmd.Parameters.AddWithValue("@listdate", s.Listdate);
            cmd.Parameters.AddWithValue("@country", s.Country);
            cmd.Parameters.AddWithValue("@industry", s.Industry);
            cmd.Parameters.AddWithValue("@sector", s.Sector);
            cmd.Parameters.AddWithValue("@marketcap", s.Marketcap);
            cmd.Parameters.AddWithValue("@employees", s.Employees);
            cmd.Parameters.AddWithValue("@phone", s.Phone);
            cmd.Parameters.AddWithValue("@ceo", s.Ceo);
            cmd.Parameters.AddWithValue("@url", s.Url);
            cmd.Parameters.AddWithValue("@description", s.Description);
            cmd.Parameters.AddWithValue("@exchange", s.Exchange);
            cmd.Parameters.AddWithValue("@name", s.Name);
            cmd.Parameters.AddWithValue("@symbol", s.Symbol);
            cmd.Parameters.AddWithValue("@hq_address", s.Hq_address);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteStock(int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Brijesh\source\repos\SocProject\StockService\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Stock where ID=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Stock GetStock(int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Brijesh\source\repos\SocProject\StockService\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Stock WHERE ID=@id";
            SqlParameter p = new SqlParameter("@id", id);
            cmd.Parameters.Add(p);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Stock s = new Stock();
            while(reader.Read())
            {
                s.Logo = reader.GetString(0);
                s.Listdate = reader.GetString(1);
                s.Country = reader.GetString(2);
                s.Industry = reader.GetString(3);
                s.Sector = reader.GetString(4);
                s.Marketcap = reader.GetString(5);
                s.Employees = reader.GetString(6);
                s.Phone = reader.GetString(7);
                s.Ceo = reader.GetString(8);
                s.Url = reader.GetString(9);
                s.Description = reader.GetString(10);
                s.Exchange = reader.GetString(11);
                s.Name = reader.GetString(12);
                s.Symbol = reader.GetString(13);
                s.Hq_address = reader.GetString(14);
                s.Id = reader.GetInt32(15);
            }
            reader.Close();
            con.Close();
            return s;
        }

        public DataSet GetStocks()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Stock", @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Brijesh\source\repos\SocProject\StockService\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            DataSet ds = new DataSet();
            da.Fill(ds, "Stock");
            return ds;
        }

        public bool updateStock(Stock s,int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Brijesh\source\repos\SocProject\StockService\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Stock set logo=@logo,listdate=@listdate,country=@country,industry=@industry,sector=@sector,marketcap=@marketcap,employees=@employees,phone=@phone,ceo=@ceo,url=@url,description=@description,exchange=@exchange,name=@name,symbol=@symbol,hq_address=@hq_address where ID=@id", con);
            cmd.Parameters.AddWithValue("@logo", s.Logo);
            cmd.Parameters.AddWithValue("@listdate", s.Listdate);
            cmd.Parameters.AddWithValue("@country", s.Country);
            cmd.Parameters.AddWithValue("@industry", s.Industry);
            cmd.Parameters.AddWithValue("@sector", s.Sector);
            cmd.Parameters.AddWithValue("@marketcap", s.Marketcap);
            cmd.Parameters.AddWithValue("@employees", s.Employees);
            cmd.Parameters.AddWithValue("@phone", s.Phone);
            cmd.Parameters.AddWithValue("@ceo", s.Ceo);
            cmd.Parameters.AddWithValue("@url", s.Url);
            cmd.Parameters.AddWithValue("@description", s.Description);
            cmd.Parameters.AddWithValue("@exchange", s.Exchange);
            cmd.Parameters.AddWithValue("@name", s.Name);
            cmd.Parameters.AddWithValue("@symbol", s.Symbol);
            cmd.Parameters.AddWithValue("@hq_address", s.Hq_address);
            cmd.Parameters.AddWithValue("@id", id);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
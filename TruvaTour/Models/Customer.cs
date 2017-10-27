using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruvaTour.Interfaces;
using TruvaTour.Services;

namespace TruvaTour.Models
{
    public class Customer:IBuy,IEvaluate
    {
        private string _name;
        private string _surname;
        private string _TCNO;
        private string _TelNo;
        private int _CustomerID;

        public string Name { get { return _name; } }
        public string Surname { get { return _surname; } }
        public string TCNO { get { return _TCNO; } }
        public string TelNo { get { return _TelNo; } }
        public int CustomerID { get { return _CustomerID; } }

        public Customer(string UserName, string Password)
        {
            ConnectDB conDB = new ConnectDB("baglanti");
            SqlCommand cmd = conDB.createSpCommand();
            cmd.CommandText = "getCustomerData";            
            cmd.Parameters.AddWithValue("@UserName",UserName);
            cmd.Parameters.AddWithValue("@Password",Password);


            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
         
                _name = rd.GetString(1);
                _surname = rd.GetString(2);
                _TCNO = rd.GetString(5);
                _TelNo = rd.GetString(6);
                _CustomerID = rd.GetInt32(0);              
            }
        }

        public void Evaluate(int TourID,int Vote, string Comment)
        {
            ConnectDB conDB = new ConnectDB("baglanti");
            SqlCommand cmd = conDB.createSpCommand();
            cmd.CommandText = "Evaluate";
            cmd.Parameters.AddWithValue("@TourID", TourID);
            cmd.Parameters.AddWithValue("@CustomerID", _CustomerID);
            cmd.Parameters.AddWithValue("@Vote", Vote);
            cmd.Parameters.AddWithValue("@Comment", Comment);
            cmd.ExecuteNonQuery();
           
        }

        public void Evaluate(int TourID,int Vote)
        {
            ConnectDB conDB = new ConnectDB("baglanti");
            SqlCommand cmd = conDB.createSpCommand();
            cmd.CommandText = "Evaluate";
            cmd.Parameters.AddWithValue("@TourID", TourID);
            cmd.Parameters.AddWithValue("@CustomerID", _CustomerID);
            cmd.Parameters.AddWithValue("@Vote", Vote);
            cmd.Parameters.AddWithValue("@Comment", "");
            cmd.ExecuteNonQuery();
        }

        public string Buy(int tourID, int quantity)
        {
            ConnectDB conDB = new ConnectDB("baglanti");
            SqlCommand cmd = conDB.createSpCommand();
            cmd.CommandText = "buy";
            cmd.Parameters.AddWithValue("@CustomerID", _CustomerID);
            cmd.Parameters.AddWithValue("@TourID", tourID);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                return "Satış Başarılı";
            }
            else
            {
                return "Satış Başarısız";
            }
        }
    }
}

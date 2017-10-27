using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruvaTour.Services;

namespace TruvaTour.Models
{
    public class Evaluation
    {

        private int _tourID;
        private int _customerID;
        private string _customerName;
        private string _customerSurname;
        private int _vote;
        private string _comment;        

        public int TourID { get { return _tourID; } }
        public int CustomerID { get { return _customerID; } }
        public int Vote { get { return _vote; } }
        public string Comment { get { return _comment; } }

        public string CustomerName { get { return _customerName; } }
        public string CustomerSurName { get { return _customerSurname; } }



        public Evaluation()
        {

        }

        public Evaluation(int tourID, int customerID)
        {
            _tourID = tourID;
            _customerID = customerID;
            ConnectDB conDB = new ConnectDB("baglanti");
            SqlCommand cmd = conDB.createSpCommand();
            cmd.CommandText = "getTourEvaluation";
            cmd.Parameters.AddWithValue("@tourID", tourID);
            cmd.Parameters.AddWithValue("@customerID", customerID);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                _customerName = rd.GetString(0);
                _customerSurname = rd.GetString(1);
                _vote = rd.GetInt32(2);
                _comment = rd.GetString(3);
            }
        }

        public List<Evaluation> Evaluations(int tourID)
        {
            ConnectDB conDB = new ConnectDB("baglanti");
            SqlCommand cmd = conDB.createSpCommand();
            cmd.CommandText = "getTourEvaluations";
            cmd.Parameters.AddWithValue("@tourID", tourID);
            SqlDataReader rd = cmd.ExecuteReader();
            List<Evaluation> elist = new List<Evaluation>();
            while (rd.Read())
            {
                int _listCustomerID = rd.GetInt32(0);
                Evaluation _listEvaluation = new Evaluation(tourID, _listCustomerID);
                elist.Add(_listEvaluation);
            }


            return elist;
        }

        public int getVoteAvg(int tourID)
        {
            int _voteAvg = 0;
            ConnectDB conDB = new ConnectDB("baglanti");
            SqlCommand cmd = conDB.createSpCommand();
            cmd.CommandText = "getTourVoteAvg";
            cmd.Parameters.AddWithValue("@tourID", tourID);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                _voteAvg = rd.GetInt32(0);
            }
            return _voteAvg;
        }
    }
}

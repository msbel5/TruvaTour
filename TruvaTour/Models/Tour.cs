using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruvaTour.Services;

namespace TruvaTour.Models
{
    public class Tour
    {
        private int _TourID;
        private string _TourName;
        private DateTime _StartDate;
        private DateTime _EndDate;
        private string _Type;
        private decimal _Price;
        private int _Quota;
        private string _TourDetails;
        private string _OriginCity;
        private string _DestinationCity;
        private string _LicensePlate;        

        public int TourID { get { return _TourID; } }
        public string TourName { get { return _TourName; } }
        public DateTime StartDate { get { return _StartDate; } }
        public DateTime EndDate { get { return _EndDate; } }
        public string Type { get { return _Type; } }
        public decimal Price { get { return _Price; } }
        public int Quota { get { return _Quota; } }
        public string TourDetails { get { return _TourDetails; } }
        public string OriginCity { get { return _OriginCity; } }
        public string DestinationCity { get { return _DestinationCity; } }
        public string LicensePlate { get { return _LicensePlate; } }

        public Tour()
        {

        }


        public Tour(int TourID)
        {
            _TourID = TourID;
            ConnectDB conDB = new ConnectDB("baglanti");
            SqlCommand cmd = conDB.createSpCommand();
            cmd.CommandText = "getTourData";
            cmd.Parameters.AddWithValue("@tourID", TourID);


            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                _TourName=rd.GetString(1);
                _StartDate=rd.GetDateTime(2);
                _EndDate=rd.GetDateTime(3);
                _Type=rd.GetString(4);
                _Price=rd.GetDecimal(5);
                _Quota=rd.GetInt32(6);
                _TourDetails=rd.GetString(7);
                _LicensePlate=rd.GetString(10);
                _OriginCity=rd.GetString(8);
                _DestinationCity=rd.GetString(9);                

            }
        }

        public List<Tour> TourList()
        {
            ConnectDB conDB = new ConnectDB("baglanti");
            SqlCommand cmd = conDB.createSpCommand();
            cmd.CommandText = "GetAllTourData";
            SqlDataReader rd = cmd.ExecuteReader();
            List<Tour> tlist = new List<Tour>();
            while (rd.Read())
            {
                int _listTourID = rd.GetInt32(0);
                Tour _listTour = new Tour(_listTourID);                
                tlist.Add(_listTour);
            }


            return tlist;
        }
    }
}

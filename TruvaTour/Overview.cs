using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruvaTour.Models;
using TruvaTour.Services;

namespace TruvaTour
{
    public partial class Overview : Form
    {
        Customer _currentCustomer;
        Tour _currentTour;
        int quota = 0;
        int tourID;
        int quantity;


        public Overview()
        {
            InitializeComponent();
        }

        public Overview(Customer CurrentCustomer) : this()
        {
            _currentCustomer = CurrentCustomer;
        }

        public void FillData(ListView lstv)
        {
            lstv.Items.Clear();
            Tour tt = new Tour();
            List<Tour> tlist = new List<Tour>();
            tlist = tt.TourList();
            foreach (var item in tlist)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.TourID.ToString();
                li.SubItems.Add(item.TourName);
                li.SubItems.Add(item.Price.ToString());
                li.SubItems.Add(item.Quota.ToString());
                lstv.Items.Add(li);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FillData(lstvTours);
            bttnBuy.Enabled = false;
            bttnDetails.Enabled = false;
        }

        private void lstvTours_SelectedIndexChanged(object sender, EventArgs e)
        {


            var quotaText = (lstvTours.FocusedItem.SubItems[3].Text);
            quota = int.Parse(quotaText);
            nudQuantity.Maximum = quota;
            var tourIDText = lstvTours.FocusedItem.SubItems[0].Text;
            tourID = int.Parse(tourIDText);
            _currentTour = new Tour(tourID);
            bttnBuy.Enabled = true;
            bttnDetails.Enabled = true;


        }

        private void bttnDetails_Click(object sender, EventArgs e)
        {
            Details dts = new Details(_currentCustomer, _currentTour);
            Hide();
            dts.Show();
        }

        private void bttnBuy_Click(object sender, EventArgs e)
        {
            if (nudQuantity.Value>0)
            {
                quantity = Convert.ToInt32(nudQuantity.Value);
                string result = _currentCustomer.Buy(tourID, quantity);
                MessageBox.Show(result);
                FillData(lstvTours);
                bttnBuy.Enabled = false;
            }
            else
                MessageBox.Show("Geçerli bir değer giriniz.");
        }

        private void Overview_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class Details : Form
    {
        Customer _currentCostumer;
        Tour _currentTour;
        Evaluation _currentEvaluation;
        RadioButton[] VoteArray;
        
        public Details()
        {
            InitializeComponent();
        }

        public Details(Customer currentCustomer, Tour currentTour) : this()
        {
            _currentCostumer = currentCustomer;
            _currentTour = currentTour;
            _currentEvaluation = new Evaluation(currentTour.TourID, currentCustomer.CustomerID);
        }

        private void Details_Load(object sender, EventArgs e)
        {
            lblTourDetails.Text = _currentTour.TourDetails;
            lblTourName.Text = _currentTour.TourName;
            lblAvgVote.Text = new Evaluation().getVoteAvg(_currentTour.TourID).ToString();
            FillData(lstvEvaluations);
            VoteArray = new RadioButton[] { rdb1, rdb2, rdb3, rdb4, rdb5 };

            foreach (var item in VoteArray)
            {
                if (item.Text == _currentEvaluation.Vote.ToString())
                    item.Checked = true;
            }            
            txtbComment.Text = _currentEvaluation.Comment;
            if (VoteArray.Any(RadioButton => RadioButton.Checked))
            {
                bttnEvaluate.Text = "Güncelle";
            }
        }

        public void FillData(ListView lstv)
        {
            lstv.Items.Clear();
            Evaluation ev = new Evaluation();
            List<Evaluation> elist = new List<Evaluation>();
            elist = ev.Evaluations(_currentTour.TourID);
            foreach (var item in elist)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.CustomerName + " " + item.CustomerSurName;
                li.SubItems.Add(item.Vote.ToString());
                li.SubItems.Add(item.Comment);               
                lstv.Items.Add(li);
            }
        }

        private void bttnEvaluate_Click(object sender, EventArgs e)
        {
            if (VoteArray.Any(RadioButton => RadioButton.Checked))
            {
                int vote=0;                
                foreach (var item in VoteArray)
                {
                    if (item.Checked == true)
                        vote = int.Parse(item.Text);
                }
                if (txtbComment.Text.Length>0)
                {
                    _currentCostumer.Evaluate(_currentTour.TourID, vote, txtbComment.Text);
                }
                else
                {
                    _currentCostumer.Evaluate(_currentTour.TourID, vote);
                }
            }
            else
                MessageBox.Show("Lütfen Puan Veriniz");

            FillData(lstvEvaluations);
            lblAvgVote.Text= new Evaluation().getVoteAvg(_currentTour.TourID).ToString();
        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            Hide();
            Overview ovr = new Overview(_currentCostumer);
            ovr.Show();
        }

        private void Details_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

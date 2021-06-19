using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SDV601Ass2_Program
{
    public partial class FrmAddTour : Form
    {
        protected ClsTour _Tour;

        public FrmAddTour()
        {
            InitializeComponent();
        }

        private void FrmAddTour_Load(object sender, EventArgs e)
        {
            CbCostType.DataSource = _Tour.CostType;
            CbCostType.SelectedIndex = 0;

            UpdateDisplay();
        }

        public bool ShowDialog(ClsTour prTour)
        {
            _Tour = prTour;
            UpdateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        private void UpdateDisplay()
        {
            TxtTourCode.Text = _Tour.TourCode;
            TxtTourName.Text = _Tour.TourName;
            DTStartDate.Value = _Tour.StartDate;
            DTEndDate.Value = _Tour.EndDate;
            NudTravDist.Value = _Tour.TravelDistance;
            NudMaxPass.Value = _Tour.MaxPassengerAmount;
            NudMarkUp.Value = _Tour.MarkUpPercentage;

            TxtTourCode.Enabled = String.IsNullOrEmpty(_Tour.TourCode);

            LbTourCosts.DataSource = null;
            LbTourCosts.DataSource = _Tour.CostList.ToList<ClsCost>();
            UpdateTotals();
        }

        private void UpdateTotals()
        {
            LblOverallExpensesAmt.Text = _Tour.calcExpensesTotal().ToString("0.00");
            LblTourCost.Text = _Tour.calcTourTotal().ToString("0.00");
            LblPassengerPrice.Text = _Tour.calcPricePerPassenger().ToString("0.00");
        }


        protected virtual void pushData()
        {
            _Tour.TourCode = TxtTourCode.Text;
            _Tour.TourName = TxtTourName.Text;
            _Tour.StartDate = DTStartDate.Value;
            _Tour.EndDate = DTEndDate.Value;
            _Tour.TravelDistance = NudTravDist.Value;
            _Tour.MaxPassengerAmount = Convert.ToInt16(NudMaxPass.Value);
            _Tour.MarkUpPercentage = NudMarkUp.Value;
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (TxtTourCode.Enabled && ClsCompany.TourList.ContainsKey(TxtTourCode.Text))
            {
                MessageBox.Show("Please enter a unique tour code and try again.", "Duplicate Tour Code Detected.");
            }

            else if (string.IsNullOrWhiteSpace(TxtTourName.Text))
            {
                MessageBox.Show("Please enter a tour name and try again.", "No Tour Name Detected.");
                TxtTourName.Text = "";
            }

            else if (string.IsNullOrWhiteSpace(TxtTourCode.Text))
            {
                MessageBox.Show("Please enter a tour code and try again.", "No Tour Code Detected.");
                TxtTourCode.Text = "";
            }

            else if (NudMaxPass.Value == 0)
            {
                MessageBox.Show("Please enter at least 1 or more tour passengers and try again.", "No Tour Passengers Detected.");
            }

            else
            {
                pushData();
                DialogResult = DialogResult.OK;
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BtnAddCost_Click(object sender, EventArgs e)
        {
            ClsCost lcCost = ClsCost.NewCost(CbCostType.SelectedIndex);
            pushData();
            if (lcCost != null && lcCost.ViewEdit())
            {
                _Tour.CostList.Add(lcCost);
                UpdateDisplay();
            }
        }

        private void BtnEditCost_Click(object sender, EventArgs e)
        {
            EditCost();
        }

        private void EditCost()
        {
            ClsCost lcCost = (ClsCost)LbTourCosts.SelectedItem;

            if (lcCost != null && lcCost.ViewEdit())
            {
                UpdateDisplay();
            }
        }

        private void BtnRemCost_Click(object sender, EventArgs e)
        {
            DialogResult lcresult = MessageBox.Show("Are you sure you want to delete this tour cost?",
                                                    "Tour Cost Deletion Requested",
                                                    MessageBoxButtons.YesNo);

            if (lcresult == DialogResult.Yes)
            {
                ClsCost tempCost = LbTourCosts.SelectedItem as ClsCost;
                _Tour.CostList.Remove(tempCost);

                UpdateDisplay();
            }
        }

        private void LbTourCosts_DoubleClick(object sender, EventArgs e)
        {
            EditCost();

        }

        private void NudMaxPass_ValueChanged(object sender, EventArgs e)
        {
            _Tour.calcExpensesTotal();
            _Tour.calcTourTotal();
            _Tour.calcPricePerPassenger();

            UpdateTotals();
        }

        private void NudTravDist_ValueChanged(object sender, EventArgs e)
        {
            _Tour.calcExpensesTotal();
            _Tour.calcTourTotal();
            _Tour.calcPricePerPassenger();

            UpdateTotals();
        }

        private void NudMarkUp_ValueChanged(object sender, EventArgs e)
        {
            _Tour.calcExpensesTotal();
            _Tour.calcTourTotal();
            _Tour.calcPricePerPassenger();

            UpdateTotals();
        }

        private void DTStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (DTStartDate.Value < DateTime.Now)
            {
                DTStartDate.Value = _Tour.StartDate;
            }
            _Tour.calcExpensesTotal();
            _Tour.calcTourTotal();
            _Tour.calcPricePerPassenger();

            UpdateTotals();
        }

        private void DTEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (DTEndDate.Value < DTStartDate.Value)
            {
                DTEndDate.Value = _Tour.EndDate;
            }
            _Tour.calcExpensesTotal();
            _Tour.calcTourTotal();
            _Tour.calcPricePerPassenger();

            UpdateTotals();
        }
    }
    }


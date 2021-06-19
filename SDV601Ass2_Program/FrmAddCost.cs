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
    public partial class FrmAddCost : Form
    {

        protected ClsCost _Cost;

        public FrmAddCost()
        {
            InitializeComponent();
        }

        public bool ShowDialog(ClsCost prCost)
        {
            _Cost = prCost;
            UpdateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        protected virtual void UpdateDisplay()
        {
            TxtCostName.Text = _Cost.CostName;
            NudCostAmount.Value = _Cost.InputAmount;
        }


        protected virtual void PushData()
        {
            _Cost.CostName = TxtCostName.Text;
            _Cost.InputAmount = NudCostAmount.Value;
        }

        private void BtnSaveCost_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCostName.Text))
            {
                MessageBox.Show("Please enter a cost name and try again.", "No Cost Name Detected.");
            }
            else
            {
                PushData();

                DialogResult = DialogResult.OK;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }

}


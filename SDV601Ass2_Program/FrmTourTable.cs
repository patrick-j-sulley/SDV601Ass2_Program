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
    public partial class FrmTourTable : Form
    {
        //ClsCompany _Company = new ClsCompany();


        private IComparer<ClsTour>[] _Comparer =
{ new ClsNameComparer(), new ClsStartDateComparer() };



        public FrmTourTable()
        {
            InitializeComponent();
            CbSortBy.DataSource = ClsCompany.SortByType;
            CbSortBy.SelectedIndex = 0;
            try
            {
                ClsCompany.RetrieveTours();
            }
            catch (Exception)
            {
                MessageBox.Show("If this is your first time opening this program, ignore this message.","No Save File Loaded");
            }
            UpdateDisplay();
            TmrAutoSave.Start();
        }


        private void EditTour()
        {
            ClsTour lcTour = (ClsTour)LbTours.SelectedItem;

            if (lcTour != null && lcTour.ViewEdit())
            {
                UpdateDisplay();
                ClsCompany.SaveTours();
            }

        }

        private void UpdateDisplay()
        {
            LbTours.DataSource = null;
            LbTours.DataSource = ClsCompany.TourList.Values.ToList<ClsTour>();
            List<ClsTour> lcTourList =
        ClsCompany.TourList.Values.ToList();
            lcTourList.Sort(_Comparer[CbSortBy.SelectedIndex]);
            LbTours.DataSource = lcTourList;

        }



        private void FrmTourTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ClsCompany.SaveTours();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
                e.Cancel = true;
            }
        }

        private void BtnAddTour_Click(object sender, EventArgs e)
        {
            ClsTour lcTour = new ClsTour();

            if (lcTour != null && lcTour.ViewEdit())
            {
                ClsCompany.TourList.Add(lcTour.TourCode, lcTour);
                UpdateDisplay();
                ClsCompany.SaveTours();
            }
        }

        private void BtnDeleteTour_Click(object sender, EventArgs e)
        {
            DialogResult lcresult = MessageBox.Show("Are you sure you want to delete this tour?",
                                        "Tour Deletion Requested",
                                        MessageBoxButtons.YesNo);

            if (lcresult == DialogResult.Yes)
            {
                ClsTour tempTour = LbTours.SelectedItem as ClsTour;
                ClsCompany.TourList.Remove(tempTour.TourCode);

                UpdateDisplay();
            }
        }

        private void TmrAutoSave_Tick(object sender, EventArgs e)
        {
            ClsCompany.SaveTours();
        }

        private void BtnEditTour_Click(object sender, EventArgs e)
        {

            EditTour();

        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {

            ClsCompany.SaveTours();
            Application.Exit();

        }

        private void LbTours_DoubleClick(object sender, EventArgs e)
        {
            EditTour();
        }

        private void CbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
    }


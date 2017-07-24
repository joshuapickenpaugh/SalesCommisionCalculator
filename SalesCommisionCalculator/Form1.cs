//Joshua Pickenpaugh
//July 24th, 2017
//Commission Calculator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesCommisionCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            //Populates combo boxes for height and weight...:     
            //Height:
            for (int i = 0; i < 9999; i++)
            {
                cmbItem1.Items.Add(i);
            }

            for (int i = 0; i < 9999; i++)
            {
                cmbItem2.Items.Add(i);
            }

            for (int i = 0; i < 9999; i++)
            {
                cmbItem3.Items.Add(i);
            }

            for (int i = 0; i < 9999; i++)
            {
                cmbItem4.Items.Add(i);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //No code here.
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double dblItem1;
            double dblItem2;
            double dblItem3;
            double dblItem4;
            double dblTotal;

            const double ITEM_PRICE_1 = 239.99;
            const double ITEM_PRICE_2 = 129.75;
            const double ITEM_PRICE_3 = 99.95;
            const double ITEM_PRICE_4 = 350.89;
            const double WEEKLY_BASE_PAY = 200.00;

            //Gets selected item from combo boxes, assigns it to 
            //a variable:
            Object selectedItem1 = cmbItem1.SelectedItem;
            dblItem1 = Convert.ToDouble(selectedItem1.ToString());

            Object selectedItem2 = cmbItem1.SelectedItem;
            dblItem2 = Convert.ToDouble(selectedItem2.ToString());

            Object selectedItem3 = cmbItem1.SelectedItem;
            dblItem3 = Convert.ToDouble(selectedItem3.ToString());

            Object selectedItem4 = cmbItem1.SelectedItem;
            dblItem4 = Convert.ToDouble(selectedItem4.ToString());

            //Calculates:
            dblItem1 = (dblItem1 * ITEM_PRICE_1) * .09;
            dblItem2 = (dblItem2 * ITEM_PRICE_2) * .09;
            dblItem3 = (dblItem3 * ITEM_PRICE_3) * .09;
            dblItem4 = (dblItem4 * ITEM_PRICE_4) * .09;

            dblTotal = (dblItem1 + dblItem2 + dblItem3 + dblItem4) + WEEKLY_BASE_PAY;

            lblTotal.Text = Convert.ToString(dblTotal.ToString("N2"));
        }
    }
}

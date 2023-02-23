using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EaseyBudget
{
    public partial class ViewExpense : Form
    {
        public ViewExpense()
        {
            InitializeComponent();
        }

        private void searchbtn_MouseEnter(object sender, EventArgs e)
        {
            searchbtn1.FlatStyle = FlatStyle.Popup;
            searchbtn1.BackColor = Color.Cyan;
        }

        private void searchbtn_MouseHover(object sender, EventArgs e)
        {
            searchbtn1.FlatStyle = FlatStyle.Popup;
            searchbtn1.BackColor = Color.Cyan;
        }

        private void searchbtn_MouseLeave(object sender, EventArgs e)
        {
            searchbtn1.FlatStyle = FlatStyle.Flat;
            searchbtn1.BackColor = Color.Transparent;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn2_MouseEnter(object sender, EventArgs e)
        {
            searchbtn2.FlatStyle = FlatStyle.Popup;
            searchbtn2.BackColor = Color.Cyan;
        }

        private void searchbtn2_MouseHover(object sender, EventArgs e)
        {
            searchbtn2.FlatStyle = FlatStyle.Popup;
            searchbtn2.BackColor = Color.Cyan;
        }

        private void searchbtn2_MouseLeave(object sender, EventArgs e)
        {
            searchbtn2.FlatStyle = FlatStyle.Flat;
            searchbtn2.BackColor = Color.Transparent;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string tt;
            minhlbl.Text = DateTime.Now.ToString("hh:mm");
            seclbl.Text = DateTime.Now.ToString("ss");
            lbldate.Text = DateTime.Now.ToString("MMMM dd yyyy").ToUpper();
            lblday.Text = DateTime.Now.ToString("dddd").ToUpper();
            tt = DateTime.Now.ToString("tt");
            if (tt == "AM")
            {
                ampmlbl1.ForeColor = Color.Yellow;
            }
            else if (tt == "PM")
            {
                ampmlbl2.ForeColor = Color.Yellow;
            }
            else
            {
                ampmlbl1.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void ViewExpense_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}

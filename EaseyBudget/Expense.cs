using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace EaseyBudget
{
    public partial class Expense : Form
    {
        public static string AmountText { get; set; }
        public static string DateText { get; set; }

        public Expense()
        {
            InitializeComponent();
        }

        private void Expense_Load(object sender, EventArgs e)
        {

        }

        private void expcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                gmapbg.SendToBack();
                googleweb.ScriptErrorsSuppressed = true;
                googleweb.Navigate("about:blank");

                RegistryKey regKey = Registry.CurrentUser;
                regKey = regKey.CreateSubKey(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", RegistryKeyPermissionCheck.ReadWriteSubTree);

                regKey.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", 11001, RegistryValueKind.DWord);
                regKey.Close();

                string loc = locoftrans.Text;
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://google.com/maps?q=");

                if (loc != string.Empty)
                {
                    queryaddress.Append(loc);
                }
                googleweb.Navigate(queryaddress.ToString());
            }
            catch(Exception ex)
            {
                //EXCEPTION
            }
        }

        private void proceedbtn_Click(object sender, EventArgs e)
        {
            string name, category, location, details, mm, dd, yy;
            double amount;
            name = nametxt.Text;
            category = expcategory.Text;
            location = locoftrans.Text;
            details = detailstxt.Text;

            if(name == "" || category == "" || amountxt.Text == "")
                MessageBox.Show("Name of Expense, Category, and Expense Amount must be completely filled up.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                amount = double.Parse(amountxt.Text);
                AmountText = ($"Php {amount.ToString("N2")}");
                mm = DateTime.Now.ToString("MM");
                dd = DateTime.Now.ToString("dd");
                yy = DateTime.Now.ToString("yyyy");
                DateText = ($"{mm}-{dd}-{yy}");
                MessageBox.Show("Information entered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                expcategory.SelectedIndex = -1; // sets the selected index to -1 (i.e. no selection)
                amountxt.Text = location = details = nametxt.Text = "";
            }

        }

        private void amountxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true; 
            }
        }
    }
}

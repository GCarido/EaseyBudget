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
    }
}

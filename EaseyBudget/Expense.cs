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
using MySql.Data.MySqlClient;

namespace EaseyBudget
{
    public partial class Expense : Form
    {
        public static string AmountText { get; set; }
        public static string DateText { get; set; }
        public static string NameofExpense1 { get; set; }
        public static string CategoryExpense1 { get; set; }
        public static string AmountExpense1 { get; set; }
        public static string LocationExpense1 { get; set; }
        public static string DetailsExpense1 { get; set; }

        string dataInfo = "server=localhost;"
                        + "password=Admin1234-;"
                        + "user=root;"
                        + "database=expenserec;"
                        + "port=3306;";

        MySqlConnection Sqlcon = new MySqlConnection();
        MySqlCommand Sqlcmd = new MySqlCommand();
        DataTable sqldt = new DataTable();
        String sqlQuery;
        MySqlDataAdapter sqldta = new MySqlDataAdapter();
        MySqlDataReader sqlrd;
        DataSet ds = new DataSet();

        private void UploadData()
        {

            Sqlcon.ConnectionString = dataInfo;
            Sqlcon.Open();
            Sqlcmd.Connection = Sqlcon;
            Sqlcmd.CommandText = ($"SELECT * FROM expenserec.expenset WHERE username = '{Login.Username}';");
            sqlrd = Sqlcmd.ExecuteReader();
            sqldt.Load(sqlrd);
            sqlrd.Close();
            Sqlcon.Close();
        }

        public Expense()
        {
            InitializeComponent();
        }

        private void Expense_Load(object sender, EventArgs e)
        {
           
            this.AcceptButton = proceedbtn;
            
            nametxt.Text = NameofExpense1;
            expcategory.Text = CategoryExpense1;
            amountxt.Text = AmountExpense1;
            locoftrans.Text = LocationExpense1;
            detailstxt.Text = DetailsExpense1;
           

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
            MySqlConnection conn = new MySqlConnection(dataInfo);
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
                if (MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    String querry = ($"SELECT * FROM expenserec.expenset WHERE username = '{Login.Username}' AND Expense_Name = '{nametxt.Text}'");
                    MySqlDataAdapter sda = new MySqlDataAdapter(querry, conn);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);
                    if (dtable.Rows.Count > 0)
                    {
                        if (MessageBox.Show("This expense name already existed, Do you want to update instead?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                
                            Sqlcon.ConnectionString = dataInfo;
                            Sqlcon.Open();
                            MySqlCommand sqlcmd = new MySqlCommand();
                            sqlcmd.Connection = Sqlcon;
                            sqlcmd.CommandText = "UPDATE expenserec.expenset SET Category_Type = @Category_Type, " +
                                "Expense_Amount = @Expense_Amount, Transaction_Location = @Transaction_Location, " +
                                "Add_Details = @Add_Details WHERE Expense_Name = " +
                                "@Expense_Name;";
                            sqlcmd.CommandType = CommandType.Text;
                            sqlcmd.Parameters.AddWithValue("@Expense_Name", nametxt.Text);
                            sqlcmd.Parameters.AddWithValue("@Category_Type", expcategory.Text);
                            sqlcmd.Parameters.AddWithValue("@Expense_Amount", amountxt.Text);
                            sqlcmd.Parameters.AddWithValue("@Transaction_Location", locoftrans.Text);
                            sqlcmd.Parameters.AddWithValue("@Add_Details", detailstxt.Text);
                  
                            sqlcmd.ExecuteNonQuery();
                            Sqlcon.Close();
                            UploadData();
              
                            MessageBox.Show("The expense record has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            expcategory.SelectedIndex = -1;
                            amountxt.Text = locoftrans.Text = detailstxt.Text = nametxt.Text = "";
                        }
                    }
                    else 
                    { 
                    amount = double.Parse(amountxt.Text);
                    AmountText = ($"Php {amount.ToString("N2")}");
                    mm = DateTime.Now.ToString("MM");
                    dd = DateTime.Now.ToString("dd");
                    yy = DateTime.Now.ToString("yyyy");
                    DateText = ($"{mm}-{dd}-{yy}");
                    MessageBox.Show("Information entered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    Sqlcon.ConnectionString = dataInfo;
                    Sqlcon.Open();
                    try
                    {
                        sqlQuery = ($"INSERT INTO expenset(username, Expense_Name, Category_Type, Expense_Amount, Transaction_Location, Add_Details, Date_Recorded) " +
                            $"VALUES('{Login.Username}', '{name}', '{category}', {amount:F2}, '{location}', '{details}', STR_TO_DATE('{DateText}', '%m-%d-%Y'));");
                        Sqlcmd = new MySqlCommand(sqlQuery, Sqlcon);
                        sqlrd = Sqlcmd.ExecuteReader();
                        Sqlcon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Sqlcon.Close();
                    }
                    UploadData();
                    expcategory.SelectedIndex = -1;
                    amountxt.Text = locoftrans.Text = detailstxt.Text = nametxt.Text = "";
                }
                }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            expcategory.SelectedIndex = -1;
            amountxt.Text = locoftrans.Text = detailstxt.Text = nametxt.Text = "";
        }
    }
}

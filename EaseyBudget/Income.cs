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
    public partial class Income : Form
    {
        public static string AmountText { get; set; }
        public static string DateText { get; set; }
        public static string NameofIncome1 { get; set; }
        public static string CategoryIncome1 { get; set; }
        public static string AmountIncome1 { get; set; }
        public static string LocationIncome1 { get; set; }
        public static string DetailsIncome1 { get; set; }

        string dataInfo = "server=localhost;"
                        + "password=Admin1234-;"
                        + "user=root;"
                        + "database=incomerec;"
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
            Sqlcmd.CommandText = ($"SELECT * FROM incomerec.incomet WHERE username = '{Login.Username}';");
            sqlrd = Sqlcmd.ExecuteReader();
            sqldt.Load(sqlrd);
            sqlrd.Close();
            Sqlcon.Close();
        }

        public Income()
        {
            InitializeComponent();
        }

        private void incategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async Task initizated()
        {
            await microsoftweb.EnsureCoreWebView2Async(null);
        }

        private async void searchbtn_Click(object sender, EventArgs e)
        {
            gmapbg1.SendToBack();
            await initizated();
            microsoftweb.CoreWebView2.Navigate($"http://google.com/maps?q={locoftrans.Text}");
        }

        private void proceedbtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(dataInfo);
            string name, category, location, details, mm, dd, yy;
            double amount;
            name = nametxt.Text;
            category = incategory.Text;
            location = locoftrans.Text;
            details = detailstxt.Text;

            if (name == "" || category == "" || amountxt.Text == "")
                MessageBox.Show("Name of Income, Category, and Income Amount must be completely filled up.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    String querry = ($"SELECT * FROM incomerec.incomet WHERE username = '{Login.Username}' AND Income_Name = '{nametxt.Text}'");
                    MySqlDataAdapter sda = new MySqlDataAdapter(querry, conn);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);
                    if (dtable.Rows.Count > 0)
                    {
                        if (MessageBox.Show("This income name already existed, Do you want to update instead?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            Sqlcon.ConnectionString = dataInfo;
                            Sqlcon.Open();
                            MySqlCommand sqlcmd = new MySqlCommand();
                            sqlcmd.Connection = Sqlcon;
                            sqlcmd.CommandText = "UPDATE incomerec.incomet SET Category_Type = @Category_Type, " +
                                "Income_Amount = @Income_Amount, Transaction_Location = @Transaction_Location, " +
                                "Add_Details = @Add_Details WHERE Income_Name = " +
                                "@Income_Name;";
                            sqlcmd.CommandType = CommandType.Text;
                            sqlcmd.Parameters.AddWithValue("@Income_Name", nametxt.Text);
                            sqlcmd.Parameters.AddWithValue("@Category_Type", incategory.Text);
                            sqlcmd.Parameters.AddWithValue("@Income_Amount", amountxt.Text);
                            sqlcmd.Parameters.AddWithValue("@Transaction_Location", locoftrans.Text);
                            sqlcmd.Parameters.AddWithValue("@Add_Details", detailstxt.Text);

                            sqlcmd.ExecuteNonQuery();
                            Sqlcon.Close();
                            UploadData();

                            MessageBox.Show("The income record has been successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            incategory.SelectedIndex = -1;
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
                            sqlQuery = ($"INSERT INTO incomet(username, Income_Name, Category_Type, Income_Amount, Transaction_Location, Add_Details, Date_Recorded) " +
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
                        incategory.SelectedIndex = -1;
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

        private void Income_Load(object sender, EventArgs e)
        {
            this.AcceptButton = proceedbtn;
            nametxt.Text = NameofIncome1;
            incategory.Text = CategoryIncome1;
            amountxt.Text = AmountIncome1;
            locoftrans.Text = LocationIncome1;
            detailstxt.Text = DetailsIncome1;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            incategory.SelectedIndex = -1;
            amountxt.Text = locoftrans.Text = detailstxt.Text = nametxt.Text = "";
        }
    }
}

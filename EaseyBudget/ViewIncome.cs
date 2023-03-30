using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace EaseyBudget
{
    public partial class ViewIncome : Form
    {

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
            dgv1.DataSource = sqldt;
        }

        public ViewIncome()
        {
            InitializeComponent();
        }

        private void searchbtn1_MouseEnter(object sender, EventArgs e)
        {
            searchbtn1.FlatStyle = FlatStyle.Popup;
            searchbtn1.BackColor = Color.Cyan;
        }

        private void searchbtn1_MouseHover(object sender, EventArgs e)
        {
            searchbtn1.FlatStyle = FlatStyle.Popup;
            searchbtn1.BackColor = Color.Cyan;
        }

        private void searchbtn1_MouseLeave(object sender, EventArgs e)
        {
            searchbtn1.FlatStyle = FlatStyle.Flat;
            searchbtn1.BackColor = Color.Transparent;
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

        private void ViewIncome_Load(object sender, EventArgs e)
        {
            timer.Start();
            UploadData();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                select.Text = dgv1.SelectedRows[0].Cells[0].Value.ToString();
                Income.NameofIncome1 = dgv1.SelectedRows[0].Cells[2].Value.ToString();
                Income.CategoryIncome1 = dgv1.SelectedRows[0].Cells[3].Value.ToString();
                Income.AmountIncome1 = dgv1.SelectedRows[0].Cells[4].Value.ToString();
                Income.LocationIncome1 = dgv1.SelectedRows[0].Cells[5].Value.ToString();
                Income.DetailsIncome1 = dgv1.SelectedRows[0].Cells[6].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select the left most column of " +
                    "the specific row you wish to select " +
                    "record.", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchbtn1_Click(object sender, EventArgs e)
        {
            try
            {

                Sqlcon.ConnectionString = dataInfo;
                Sqlcon.Open();

                using (DataTable dtable = new DataTable("Income_Name"))
                {

                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM incomerec.incomet WHERE (Income_Name LIKE @Income_Name OR Income_Amount LIKE @Income_Amount OR Transaction_Location LIKE @Transaction_Location OR Add_Details LIKE @Add_Details OR Date_Recorded LIKE @Date_Recorded) AND username = @username;", Sqlcon))
                    {
                        cmd.Parameters.AddWithValue("username", Login.Username);
                        cmd.Parameters.AddWithValue("Income_Name", string.Format("%{0}%",
                            searchbox.Text));
                        cmd.Parameters.AddWithValue("Income_Amount", string.Format("%{0}%",
                           searchbox.Text));
                        cmd.Parameters.AddWithValue("Transaction_Location", string.Format("%{0}%",
                            searchbox.Text));
                        cmd.Parameters.AddWithValue("Add_Details", string.Format("%{0}%",
                            searchbox.Text));
                        cmd.Parameters.AddWithValue("Date_Recorded", string.Format("%{0}%",
                            searchbox.Text));
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dtable);
                        dgv1.DataSource = dtable;
                    }
                    Sqlcon.Close();
                    incsearch.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchbtn2_Click(object sender, EventArgs e)
        {
          
        }

        private void incsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                Sqlcon.ConnectionString = dataInfo;
                Sqlcon.Open();

                using (DataTable dtable = new DataTable("Income_Name"))
                {

                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM incomerec.incomet WHERE (Category_Type LIKE @Category_Type) AND username = @username;", Sqlcon))
                    {
                        cmd.Parameters.AddWithValue("username", Login.Username);
                        cmd.Parameters.AddWithValue("Category_Type", string.Format("%{0}%",
                            incsearch.Text));
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dtable);
                        dgv1.DataSource = dtable;
                    }
                    Sqlcon.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

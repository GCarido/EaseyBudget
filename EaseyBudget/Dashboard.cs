using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.Collections;

namespace EaseyBudget
{
    public partial class Dashboard : Form
    {
        string dataInfo1 = "server=localhost;"
                       + "password=Admin1234-;"
                       + "user=root;"
                       + "database=expenserec;"
                       + "port=3306;";

        string dataInfo2 = "server=localhost;"
                       + "password=Admin1234-;"
                       + "user=root;"
                       + "database=incomerec;"
                       + "port=3306;";

        public Dashboard()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            userntext.Text = Login.Username;
            currform.Text = "Dashboard";
            newsweb.ScriptErrorsSuppressed = true;
            newsweb.Navigate("https://news.abs-cbn.com/");
            eventsweb.ScriptErrorsSuppressed = true;
            eventsweb.Navigate("https://publicholidays.ph/2023-dates/");

            string query1 = $"SELECT MIN(Expense_Amount) FROM expenserec.expenset WHERE username='{Login.Username}';";
            string query2 = $"SELECT MAX(Expense_Amount) FROM expenserec.expenset WHERE username='{Login.Username}';";
            string query3 = $"SELECT MAX(Date_Recorded) FROM expenserec.expenset WHERE username='{Login.Username}';";
            string contentquery1 = "SELECT * FROM expenserec.expenset WHERE Date_Recorded = (SELECT MAX(Date_Recorded) FROM expenserec.expenset)";

            string query1a = $"SELECT MIN(Income_Amount) FROM incomerec.incomet WHERE username='{Login.Username}';";
            string query2a = $"SELECT MAX(Income_Amount) FROM incomerec.incomet WHERE username='{Login.Username}';";
            string query3a = $"SELECT MAX(Date_Recorded) FROM incomerec.incomet WHERE username='{Login.Username}';";
            string contentquery1a = "SELECT * FROM incomerec.incomet WHERE Date_Recorded = (SELECT MAX(Date_Recorded) FROM incomerec.incomet)";

            using (MySqlConnection connection = new MySqlConnection(dataInfo1))
            {
                MySqlCommand command1 = new MySqlCommand(query1, connection);
                MySqlCommand command2 = new MySqlCommand(query2, connection);
                MySqlCommand command3 = new MySqlCommand(query3, connection);
                MySqlCommand contentcommand = new MySqlCommand(contentquery1, connection);
                try
                {
                    connection.Open();
                    double minValue = Convert.ToDouble(command1.ExecuteScalar());
                    minexp.Text = ($"Php {minValue.ToString("N2")}");
                    double maxValue = Convert.ToDouble(command2.ExecuteScalar());
                    maxexp.Text = ($"Php {maxValue.ToString("N2")}");
                    DateTime recentDate = Convert.ToDateTime(command3.ExecuteScalar());
                    lexpdate.Text = recentDate.ToShortDateString();

                    MySqlDataReader reader = contentcommand.ExecuteReader();
                    while (reader.Read())
                    {
                        double latestamount = Convert.ToDouble(reader["Expense_Amount"]);
                        lexpam.Text = ($"Php {latestamount.ToString("N2")}");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            using (MySqlConnection connectiona = new MySqlConnection(dataInfo2))
            {
                MySqlCommand command1a = new MySqlCommand(query1a, connectiona);
                MySqlCommand command2a = new MySqlCommand(query2a, connectiona);
                MySqlCommand command3a = new MySqlCommand(query3a, connectiona);
                MySqlCommand contentcommanda = new MySqlCommand(contentquery1a, connectiona);
                try
                {
                    connectiona.Open();
                    double minValue = Convert.ToDouble(command1a.ExecuteScalar());
                    mininc.Text = ($"Php {minValue.ToString("N2")}");
                    double maxValue = Convert.ToDouble(command2a.ExecuteScalar());
                    maxinc.Text = ($"Php {maxValue.ToString("N2")}");
                    DateTime recentDate = Convert.ToDateTime(command3a.ExecuteScalar());
                    lincdate.Text = recentDate.ToShortDateString();

                    MySqlDataReader reader = contentcommanda.ExecuteReader();
                    while (reader.Read())
                    {
                        double latestamount = Convert.ToDouble(reader["Income_Amount"]);
                        lincam.Text = ($"Php {latestamount.ToString("N2")}");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void minbtn_MouseEnter(object sender, EventArgs e)
        {
            minbtn.BackColor = Color.FromArgb(68, 96, 167);
        }

        private void minbtn_MouseHover(object sender, EventArgs e)
        {
            minbtn.BackColor = Color.FromArgb(68, 96, 167);
        }

        private void minbtn_MouseLeave(object sender, EventArgs e)
        {
            minbtn.BackColor = Color.Transparent;
        }

        private void exitbtn_MouseEnter(object sender, EventArgs e)
        {
            exitbtn.BackColor = Color.FromArgb(243, 110, 111);
        }

        private void exitbtn_MouseHover(object sender, EventArgs e)
        {
            exitbtn.BackColor = Color.FromArgb(243, 110, 111);
        }

        private void exitbtn_MouseLeave(object sender, EventArgs e)
        {
            exitbtn.BackColor = Color.Transparent;
        }

        private void paneldrg_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void dashbtn_MouseEnter(object sender, EventArgs e)
        {
            dashbtn.BackColor = Color.FromArgb(240, 209, 175);
            dashbtn.Font = new Font(dashbtn.Font, FontStyle.Bold);
        }

        private void dashbtn_MouseHover(object sender, EventArgs e)
        {
            dashbtn.BackColor = Color.FromArgb(240, 209, 175);
            dashbtn.Font = new Font(dashbtn.Font, FontStyle.Bold);
        }

        private void dashbtn_MouseLeave(object sender, EventArgs e)
        {
            dashbtn.BackColor = Color.Transparent;
            dashbtn.Font = new Font(dashbtn.Font, FontStyle.Regular);
        }

        private void expensebtn_MouseEnter(object sender, EventArgs e)
        {
           expensebtn.BackColor = Color.FromArgb(240, 209, 175);
           expensebtn.Font = new Font(expensebtn.Font, FontStyle.Bold);
        }

        private void expensebtn_MouseHover(object sender, EventArgs e)
        {
           expensebtn.BackColor = Color.FromArgb(240, 209, 175);
           expensebtn.Font = new Font(expensebtn.Font, FontStyle.Bold);
        }

        private void expensebtn_MouseLeave(object sender, EventArgs e)
        {
            expensebtn.BackColor = Color.Transparent;
            expensebtn.Font = new Font(expensebtn.Font, FontStyle.Regular);
        }

        private void incomebtn_MouseEnter(object sender, EventArgs e)
        {
            incomebtn.BackColor = Color.FromArgb(240, 209, 175);
            incomebtn.Font = new Font(incomebtn.Font, FontStyle.Bold);
        }

        private void incomebtn_MouseHover(object sender, EventArgs e)
        {
            incomebtn.BackColor = Color.FromArgb(240, 209, 175);
            incomebtn.Font = new Font(incomebtn.Font, FontStyle.Bold);
        }

        private void incomebtn_MouseLeave(object sender, EventArgs e)
        {
            incomebtn.BackColor = Color.Transparent;
            incomebtn.Font = new Font(incomebtn.Font, FontStyle.Regular);
        }

        private void logoutbtn_MouseEnter(object sender, EventArgs e)
        {
            logoutbtn.BackColor = Color.FromArgb(243, 110, 111);
            logoutbtn.Font = new Font(logoutbtn.Font, FontStyle.Bold);
        }

        private void logoutbtn_MouseHover(object sender, EventArgs e)
        {
            logoutbtn.BackColor = Color.FromArgb(243, 110, 111);
            logoutbtn.Font = new Font(logoutbtn.Font, FontStyle.Bold);
        }

        private void logoutbtn_MouseLeave(object sender, EventArgs e)
        {
            logoutbtn.BackColor = Color.Transparent;
            logoutbtn.Font = new Font(logoutbtn.Font, FontStyle.Regular);
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Expense.NameofExpense1 = Expense.CategoryExpense1 = Expense.AmountExpense1 = Expense.LocationExpense1 = Expense.DetailsExpense1 = "";
            Income.NameofIncome1 = Income.CategoryIncome1 = Income.AmountIncome1 = Income.LocationIncome1 = Income.DetailsIncome1 = "";
            this.Hide();
            Login l1 = new Login();
            l1.Show();
        }

        private void expensebtn_Click(object sender, EventArgs e)
        {
            currform.Text = "Expense";
            Expense exp = new Expense();
            exp.TopLevel = false;
            formview.Controls.Add(exp);
            exp.Dock = DockStyle.Fill;
            exp.BringToFront();
            exp.Show();
            exp.FormBorderStyle = FormBorderStyle.None;
        }

        private void dashbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            currform.Text = "Dashboard";
            Dashboard dashb = new Dashboard();
            dashb.Show();
        }

        private void incomebtn_Click(object sender, EventArgs e)
        {
            currform.Text = "Income";
            Income inc = new Income();
            inc.TopLevel = false;
            formview.Controls.Add(inc);
            inc.Dock = DockStyle.Fill;
            inc.BringToFront();
            inc.Show();
            inc.FormBorderStyle = FormBorderStyle.None;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void vexpbtn_MouseEnter(object sender, EventArgs e)
        {
            vexpbtn.BackColor = Color.FromArgb(240, 209, 175);
            vexpbtn.Font = new Font(logoutbtn.Font, FontStyle.Bold);
        }

        private void vexpbtn_MouseHover(object sender, EventArgs e)
        {
            vexpbtn.BackColor = Color.FromArgb(240, 209, 175);
            vexpbtn.Font = new Font(logoutbtn.Font, FontStyle.Bold);
        }

        private void vexpbtn_MouseLeave(object sender, EventArgs e)
        {
            vexpbtn.BackColor = Color.Transparent;
            vexpbtn.Font = new Font(logoutbtn.Font, FontStyle.Regular);
        }

        private void vincbtn_MouseEnter(object sender, EventArgs e)
        {
            vincbtn.BackColor = Color.FromArgb(240, 209, 175);
            vincbtn.Font = new Font(logoutbtn.Font, FontStyle.Bold);
        }

        private void vincbtn_MouseHover(object sender, EventArgs e)
        {
            vincbtn.BackColor = Color.FromArgb(240, 209, 175);
            vincbtn.Font = new Font(logoutbtn.Font, FontStyle.Bold);
        }

        private void vincbtn_MouseLeave(object sender, EventArgs e)
        {
           vincbtn.BackColor = Color.Transparent;
           vincbtn.Font = new Font(logoutbtn.Font, FontStyle.Regular);
        }

        public void vexpbtn_Click(object sender, EventArgs e)
        {
            currform.Text = "View Expense";
            ViewExpense vexp = new ViewExpense();
            vexp.TopLevel = false;
            formview.Controls.Add(vexp);
            vexp.Dock = DockStyle.Fill;
            vexp.BringToFront();
            vexp.Show();
            vexp.FormBorderStyle = FormBorderStyle.None;
        }

        private void vincbtn_Click(object sender, EventArgs e)
        {
            currform.Text = "View Income";
            ViewIncome vinc = new ViewIncome();
            vinc.TopLevel = false;
            formview.Controls.Add(vinc);
            vinc.Dock = DockStyle.Fill;
            vinc.BringToFront();
            vinc.Show();
            vinc.FormBorderStyle = FormBorderStyle.None;
        }

        private void expensebtn_MouseDown(object sender, MouseEventArgs e)
        {
            expensebtn.BackColor = Color.FromArgb(73, 138, 247);
        }

        private void calendarbrowse_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           

        }

        private void newsweb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void eventscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            newsweb.ScriptErrorsSuppressed = true;
            if (newscb.SelectedItem == "ABS-CBN News")
            {
                newsweb.Navigate("https://news.abs-cbn.com/");
            }
            else if (newscb.SelectedItem == "GMA News Online")
            {
                newsweb.Navigate("https://www.gmanetwork.com/news/");
            }
            else if (newscb.SelectedItem == "Manila Bulletin")
            {
                newsweb.Navigate("https://mb.com.ph/");
            }
            else if (newscb.SelectedItem == "CNN Philippines")
            {
                newsweb.Navigate("https://www.cnnphilippines.com/");
            }
            else if (newscb.SelectedItem == "The Philippine Star")
            {
                newsweb.Navigate("https://www.philstar.com/");
            }
        }

        private void descdrag_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}

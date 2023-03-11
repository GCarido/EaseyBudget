using MySql.Data.MySqlClient;
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
    public partial class SignUp : Form
    {
        public static string FirstName { get; set; }

        public string mySqlServerName = "127.0.0.1";
        public string mySqlServerUserId = "root";
        public string mySqlServerPassword = "Admin1234-";
        public string mySqlDatabaseName = "users_record";
        public SignUp()
        {
            InitializeComponent();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All fields will be cleared. Do you want to continue?",
                           "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                firstntext.Texts = lastntext.Texts =
                emailtxt.Texts = userntxt.Texts = passwtxt.Texts =
                confpasstxt.Texts = "";
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if(this.passwtxt.Texts == this.confpasstxt.Texts)
            {
                // FirstName = firstntext.Texts;
                string connectionString = $"server={this.mySqlServerName};user id={this.mySqlServerUserId};password={this.mySqlServerPassword};database={this.mySqlDatabaseName}";

                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string selectQuery = $"SELECT * FROM users_table WHERE username='{this.userntxt.Texts}'";
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataReader selectDataReader = command.ExecuteReader();

                if(!selectDataReader.Read())
                {
                    connection.Close();
                    connection.Open();
                    string insertQuery = $"INSERT INTO users_table (firstname, lastname, email, username, user_password) VALUES ('{this.firstntext.Texts}','{this.lastntext.Texts}','{this.emailtxt.Texts}','{this.userntxt.Texts}','{this.passwtxt.Texts}')";
                    command = new MySqlCommand(insertQuery, connection);
                    MySqlDataReader insertDataReader = command.ExecuteReader();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Username you typed already exists...");
                }
                
                connection.Close();
            }
            else
            {
                MessageBox.Show("Passwords you typed do not match...");
                this.passwtxt.Texts = "";
                this.confpasstxt.Texts = "";
            }
            

        }
    }
}

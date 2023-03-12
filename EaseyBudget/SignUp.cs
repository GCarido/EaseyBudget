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
            if (firstntext.Texts == "" || lastntext.Texts == "" || emailtxt.Texts == "" || userntxt.Texts == "" || passwtxt.Texts == "" || confpasstxt.Texts == "")
            {
                MessageBox.Show("Incomplete Field Entry", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (this.passwtxt.Texts == this.confpasstxt.Texts)
                {
                    
                        string connectionString = $"server={this.mySqlServerName};user id={this.mySqlServerUserId};password={this.mySqlServerPassword};database={this.mySqlDatabaseName}";

                        MySqlConnection connection = new MySqlConnection(connectionString);
                        connection.Open();
                        string selectQuery = $"SELECT * FROM users_table WHERE username='{this.userntxt.Texts}'";
                        MySqlCommand command = new MySqlCommand(selectQuery, connection);
                        MySqlDataReader selectDataReader = command.ExecuteReader();

                        if (!selectDataReader.Read())
                        {
                             if (MessageBox.Show("You will be registered after clicking 'Yes'. Do you want to continue?",
                                   "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                             {
                                 connection.Close();
                                 connection.Open();
                                  string insertQuery = $"INSERT INTO users_table (firstname, lastname, email, username, user_password) VALUES ('{this.firstntext.Texts}','{this.lastntext.Texts}','{this.emailtxt.Texts}','{this.userntxt.Texts.ToLower()}','{this.passwtxt.Texts}')";
                                  command = new MySqlCommand(insertQuery, connection);
                                 MySqlDataReader insertDataReader = command.ExecuteReader();
                                 connection.Close();
                                 MessageBox.Show("You have been successfully registered", "Notice",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                                 firstntext.Texts = userntxt.Texts = lastntext.Texts = emailtxt.Texts = passwtxt.Texts = confpasstxt.Texts = "";
                             }                        
                        }
                        else
                        {
                            MessageBox.Show("Username already existed. " +
                                "Please try again.", "Notice", MessageBoxButtons.OK,
                                MessageBoxIcon.Hand);
                             userntxt.Texts = "";
                        }

                        connection.Close();
                      
                    
                }
                else
                {
                    MessageBox.Show("The password you have entered does not match. " +
                           "Please try again.", "Notice", MessageBoxButtons.OK,
                           MessageBoxIcon.Hand);
                    this.passwtxt.Texts = "";
                    this.confpasstxt.Texts = "";
                }
            }

        }
    }
}

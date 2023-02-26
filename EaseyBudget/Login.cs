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

namespace EaseyBudget
{
    public partial class Login : Form
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Login()
        {
            InitializeComponent();
        }
        string user = "user";
        string pass = "2314";

        private void Login_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.AcceptButton = loginbtn;
        }

        private void paneldrg_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void minbtn_MouseHover(object sender, EventArgs e)
        {
            minbtn.BackColor = Color.FromArgb(240, 209, 175);
        }

        private void minbtn_MouseLeave(object sender, EventArgs e)
        {
            minbtn.BackColor = Color.Transparent;
        }

        private void minbtn_MouseEnter(object sender, EventArgs e)
        {
            minbtn.BackColor = Color.FromArgb(240, 209, 175);
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

        private void signinav_MouseEnter(object sender, EventArgs e)
        {
            signinav.BackColor = Color.FromArgb(240, 209, 175);
        }

        private void signinav_MouseHover(object sender, EventArgs e)
        {
            signinav.BackColor = Color.FromArgb(240, 209, 175);

        }

        private void signinav_MouseLeave(object sender, EventArgs e)
        {
            signinav.BackColor = Color.Transparent;
        }

        private void signupnav_MouseEnter(object sender, EventArgs e)
        {
            signupnav.BackColor = Color.FromArgb(240, 209, 175);
        }

        private void signupnav_MouseHover(object sender, EventArgs e)
        {
            signupnav.BackColor = Color.FromArgb(240, 209, 175);
        }

        private void signupnav_MouseLeave(object sender, EventArgs e)
        {
            signupnav.BackColor = Color.Transparent;
        }

        private void signinav_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void signupnav_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.TopLevel = false;
            panview.Controls.Add(signup);
            signup.Dock = DockStyle.Fill;
            signup.BringToFront();
            signup.Show();
            signup.FormBorderStyle = FormBorderStyle.None;

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (usertxt.Texts == user && passtxt.Texts == pass)
            {
                Username = usertxt.Texts;
                Password = passtxt.Texts;
                this.Hide();
                Dashboard dashb = new Dashboard();
                dashb.Show();
            }
            else if (usertxt.Texts == "" || passtxt.Texts == "")
            {
                MessageBox.Show("Incomplete Field Entry", "Notice",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The password you have entered is incorrect. " +
                    "Please try again.", "Notice", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
        }

        private void passtxt_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void passtxt_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}

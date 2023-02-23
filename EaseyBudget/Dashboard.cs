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
    public partial class Dashboard : Form
    {

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
 
        }

        private void expensebtn_Click(object sender, EventArgs e)
        {
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
            Dashboard dashb = new Dashboard();
            dashb.Show();
        }

        private void incomebtn_Click(object sender, EventArgs e)
        {
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

        private void vexpbtn_Click(object sender, EventArgs e)
        {
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

    }
}

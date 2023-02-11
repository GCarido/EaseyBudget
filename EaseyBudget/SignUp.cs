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
            FirstName = firstntext.Texts;
        }
    }
}

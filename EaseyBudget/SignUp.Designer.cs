namespace EaseyBudget
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gradient1 = new EaseyBudget.Gradient();
            this.panel4 = new System.Windows.Forms.Panel();
            this.clearbtn = new System.Windows.Forms.Button();
            this.registerbtn = new System.Windows.Forms.Button();
            this.confpasstxt = new CustomControls.RJControls.RJTextBox();
            this.passwtxt = new CustomControls.RJControls.RJTextBox();
            this.userntxt = new CustomControls.RJControls.RJTextBox();
            this.emailtxt = new CustomControls.RJControls.RJTextBox();
            this.lastntext = new CustomControls.RJControls.RJTextBox();
            this.firstntext = new CustomControls.RJControls.RJTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradient1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 80F;
            this.gradient1.BotColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(227)))));
            this.gradient1.Controls.Add(this.panel4);
            this.gradient1.Controls.Add(this.panel3);
            this.gradient1.Controls.Add(this.panel2);
            this.gradient1.Controls.Add(this.panel1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(384, 461);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(227)))));
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.clearbtn);
            this.panel4.Controls.Add(this.registerbtn);
            this.panel4.Controls.Add(this.confpasstxt);
            this.panel4.Controls.Add(this.passwtxt);
            this.panel4.Controls.Add(this.userntxt);
            this.panel4.Controls.Add(this.emailtxt);
            this.panel4.Controls.Add(this.lastntext);
            this.panel4.Controls.Add(this.firstntext);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(384, 367);
            this.panel4.TabIndex = 80;
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearbtn.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.Color.Black;
            this.clearbtn.Location = new System.Drawing.Point(200, 312);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(120, 36);
            this.clearbtn.TabIndex = 7;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerbtn.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.ForeColor = System.Drawing.Color.Black;
            this.registerbtn.Location = new System.Drawing.Point(72, 312);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(120, 36);
            this.registerbtn.TabIndex = 6;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // confpasstxt
            // 
            this.confpasstxt.BackColor = System.Drawing.Color.White;
            this.confpasstxt.BorderColor = System.Drawing.Color.Black;
            this.confpasstxt.BorderFocusColor = System.Drawing.Color.Blue;
            this.confpasstxt.BorderRadius = 1;
            this.confpasstxt.BorderSize = 2;
            this.confpasstxt.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confpasstxt.ForeColor = System.Drawing.Color.Black;
            this.confpasstxt.Location = new System.Drawing.Point(70, 260);
            this.confpasstxt.Margin = new System.Windows.Forms.Padding(4);
            this.confpasstxt.Multiline = false;
            this.confpasstxt.Name = "confpasstxt";
            this.confpasstxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.confpasstxt.PasswordChar = true;
            this.confpasstxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.confpasstxt.PlaceholderText = "Confirm Password";
            this.confpasstxt.Size = new System.Drawing.Size(250, 33);
            this.confpasstxt.TabIndex = 5;
            this.confpasstxt.Texts = "";
            this.confpasstxt.UnderlinedStyle = false;
            // 
            // passwtxt
            // 
            this.passwtxt.BackColor = System.Drawing.Color.White;
            this.passwtxt.BorderColor = System.Drawing.Color.Black;
            this.passwtxt.BorderFocusColor = System.Drawing.Color.Blue;
            this.passwtxt.BorderRadius = 1;
            this.passwtxt.BorderSize = 2;
            this.passwtxt.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwtxt.ForeColor = System.Drawing.Color.Black;
            this.passwtxt.Location = new System.Drawing.Point(70, 210);
            this.passwtxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwtxt.Multiline = false;
            this.passwtxt.Name = "passwtxt";
            this.passwtxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.passwtxt.PasswordChar = true;
            this.passwtxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwtxt.PlaceholderText = "Password";
            this.passwtxt.Size = new System.Drawing.Size(250, 33);
            this.passwtxt.TabIndex = 4;
            this.passwtxt.Texts = "";
            this.passwtxt.UnderlinedStyle = false;
            // 
            // userntxt
            // 
            this.userntxt.BackColor = System.Drawing.Color.White;
            this.userntxt.BorderColor = System.Drawing.Color.Black;
            this.userntxt.BorderFocusColor = System.Drawing.Color.Blue;
            this.userntxt.BorderRadius = 1;
            this.userntxt.BorderSize = 2;
            this.userntxt.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userntxt.ForeColor = System.Drawing.Color.Black;
            this.userntxt.Location = new System.Drawing.Point(70, 160);
            this.userntxt.Margin = new System.Windows.Forms.Padding(4);
            this.userntxt.Multiline = false;
            this.userntxt.Name = "userntxt";
            this.userntxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.userntxt.PasswordChar = false;
            this.userntxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.userntxt.PlaceholderText = "Username";
            this.userntxt.Size = new System.Drawing.Size(250, 33);
            this.userntxt.TabIndex = 3;
            this.userntxt.Texts = "";
            this.userntxt.UnderlinedStyle = false;
            // 
            // emailtxt
            // 
            this.emailtxt.BackColor = System.Drawing.Color.White;
            this.emailtxt.BorderColor = System.Drawing.Color.Black;
            this.emailtxt.BorderFocusColor = System.Drawing.Color.Blue;
            this.emailtxt.BorderRadius = 1;
            this.emailtxt.BorderSize = 2;
            this.emailtxt.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.ForeColor = System.Drawing.Color.Black;
            this.emailtxt.Location = new System.Drawing.Point(70, 110);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4);
            this.emailtxt.Multiline = false;
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.emailtxt.PasswordChar = false;
            this.emailtxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.emailtxt.PlaceholderText = "Email (Optional)";
            this.emailtxt.Size = new System.Drawing.Size(250, 33);
            this.emailtxt.TabIndex = 2;
            this.emailtxt.Texts = "";
            this.emailtxt.UnderlinedStyle = false;
            // 
            // lastntext
            // 
            this.lastntext.BackColor = System.Drawing.Color.White;
            this.lastntext.BorderColor = System.Drawing.Color.Black;
            this.lastntext.BorderFocusColor = System.Drawing.Color.Blue;
            this.lastntext.BorderRadius = 1;
            this.lastntext.BorderSize = 2;
            this.lastntext.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastntext.ForeColor = System.Drawing.Color.Black;
            this.lastntext.Location = new System.Drawing.Point(70, 60);
            this.lastntext.Margin = new System.Windows.Forms.Padding(4);
            this.lastntext.Multiline = false;
            this.lastntext.Name = "lastntext";
            this.lastntext.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.lastntext.PasswordChar = false;
            this.lastntext.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lastntext.PlaceholderText = "Last Name";
            this.lastntext.Size = new System.Drawing.Size(250, 33);
            this.lastntext.TabIndex = 1;
            this.lastntext.Texts = "";
            this.lastntext.UnderlinedStyle = false;
            // 
            // firstntext
            // 
            this.firstntext.BackColor = System.Drawing.Color.White;
            this.firstntext.BorderColor = System.Drawing.Color.Black;
            this.firstntext.BorderFocusColor = System.Drawing.Color.Blue;
            this.firstntext.BorderRadius = 1;
            this.firstntext.BorderSize = 2;
            this.firstntext.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstntext.ForeColor = System.Drawing.Color.Black;
            this.firstntext.Location = new System.Drawing.Point(70, 10);
            this.firstntext.Margin = new System.Windows.Forms.Padding(4);
            this.firstntext.Multiline = false;
            this.firstntext.Name = "firstntext";
            this.firstntext.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.firstntext.PasswordChar = false;
            this.firstntext.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.firstntext.PlaceholderText = "First Name";
            this.firstntext.Size = new System.Drawing.Size(250, 33);
            this.firstntext.TabIndex = 0;
            this.firstntext.Texts = "";
            this.firstntext.UnderlinedStyle = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 5);
            this.panel3.TabIndex = 110;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 46);
            this.panel2.TabIndex = 90;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 43);
            this.panel1.TabIndex = 100;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.gradient1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.gradient1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJTextBox confpasstxt;
        private CustomControls.RJControls.RJTextBox passwtxt;
        private CustomControls.RJControls.RJTextBox userntxt;
        private CustomControls.RJControls.RJTextBox emailtxt;
        private System.Windows.Forms.Button registerbtn;
        private CustomControls.RJControls.RJTextBox lastntext;
        private CustomControls.RJControls.RJTextBox firstntext;
        private System.Windows.Forms.Button clearbtn;
    }
}
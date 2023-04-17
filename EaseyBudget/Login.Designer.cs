namespace EaseyBudget
{
    partial class Login
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
            this.grad1 = new EaseyBudget.Gradient();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accountnav = new System.Windows.Forms.Panel();
            this.signupnav = new System.Windows.Forms.Button();
            this.signinav = new System.Windows.Forms.Button();
            this.paneldrg = new System.Windows.Forms.Panel();
            this.exitbtn = new System.Windows.Forms.Button();
            this.minbtn = new System.Windows.Forms.Button();
            this.panview = new System.Windows.Forms.Panel();
            this.togglepass = new System.Windows.Forms.CheckBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passtxt = new CustomControls.RJControls.RJTextBox();
            this.usertxt = new CustomControls.RJControls.RJTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.grad1.SuspendLayout();
            this.accountnav.SuspendLayout();
            this.paneldrg.SuspendLayout();
            this.panview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // grad1
            // 
            this.grad1.Angle = 0F;
            this.grad1.BotColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(227)))));
            this.grad1.Controls.Add(this.panel1);
            this.grad1.Controls.Add(this.accountnav);
            this.grad1.Controls.Add(this.paneldrg);
            this.grad1.Controls.Add(this.panview);
            this.grad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grad1.Location = new System.Drawing.Point(0, 0);
            this.grad1.Name = "grad1";
            this.grad1.Size = new System.Drawing.Size(384, 461);
            this.grad1.TabIndex = 0;
            this.grad1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(227)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(227)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 5);
            this.panel1.TabIndex = 9;
            // 
            // accountnav
            // 
            this.accountnav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(198)))));
            this.accountnav.Controls.Add(this.signupnav);
            this.accountnav.Controls.Add(this.signinav);
            this.accountnav.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountnav.Location = new System.Drawing.Point(0, 43);
            this.accountnav.Name = "accountnav";
            this.accountnav.Size = new System.Drawing.Size(384, 46);
            this.accountnav.TabIndex = 90;
            // 
            // signupnav
            // 
            this.signupnav.BackColor = System.Drawing.Color.Transparent;
            this.signupnav.Dock = System.Windows.Forms.DockStyle.Left;
            this.signupnav.FlatAppearance.BorderSize = 0;
            this.signupnav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupnav.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupnav.Location = new System.Drawing.Point(154, 0);
            this.signupnav.Name = "signupnav";
            this.signupnav.Size = new System.Drawing.Size(154, 46);
            this.signupnav.TabIndex = 1;
            this.signupnav.Text = "Sign Up";
            this.signupnav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signupnav.UseVisualStyleBackColor = false;
            this.signupnav.Click += new System.EventHandler(this.signupnav_Click);
            this.signupnav.MouseEnter += new System.EventHandler(this.signupnav_MouseEnter);
            this.signupnav.MouseLeave += new System.EventHandler(this.signupnav_MouseLeave);
            this.signupnav.MouseHover += new System.EventHandler(this.signupnav_MouseHover);
            // 
            // signinav
            // 
            this.signinav.BackColor = System.Drawing.Color.Transparent;
            this.signinav.Dock = System.Windows.Forms.DockStyle.Left;
            this.signinav.FlatAppearance.BorderSize = 0;
            this.signinav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinav.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinav.Location = new System.Drawing.Point(0, 0);
            this.signinav.Name = "signinav";
            this.signinav.Size = new System.Drawing.Size(154, 46);
            this.signinav.TabIndex = 0;
            this.signinav.Text = "Sign In";
            this.signinav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signinav.UseVisualStyleBackColor = false;
            this.signinav.Click += new System.EventHandler(this.signinav_Click);
            this.signinav.MouseEnter += new System.EventHandler(this.signinav_MouseEnter);
            this.signinav.MouseLeave += new System.EventHandler(this.signinav_MouseLeave);
            this.signinav.MouseHover += new System.EventHandler(this.signinav_MouseHover);
            // 
            // paneldrg
            // 
            this.paneldrg.BackColor = System.Drawing.Color.Transparent;
            this.paneldrg.Controls.Add(this.exitbtn);
            this.paneldrg.Controls.Add(this.minbtn);
            this.paneldrg.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneldrg.Location = new System.Drawing.Point(0, 0);
            this.paneldrg.Name = "paneldrg";
            this.paneldrg.Size = new System.Drawing.Size(384, 43);
            this.paneldrg.TabIndex = 100;
            this.paneldrg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneldrg_MouseDown);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.BackgroundImage = global::EaseyBudget.Properties.Resources.exit1;
            this.exitbtn.FlatAppearance.BorderSize = 0;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Location = new System.Drawing.Point(353, 2);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(24, 24);
            this.exitbtn.TabIndex = 6;
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            this.exitbtn.MouseEnter += new System.EventHandler(this.exitbtn_MouseEnter);
            this.exitbtn.MouseLeave += new System.EventHandler(this.exitbtn_MouseLeave);
            this.exitbtn.MouseHover += new System.EventHandler(this.exitbtn_MouseHover);
            // 
            // minbtn
            // 
            this.minbtn.BackColor = System.Drawing.Color.Transparent;
            this.minbtn.BackgroundImage = global::EaseyBudget.Properties.Resources.min;
            this.minbtn.FlatAppearance.BorderSize = 0;
            this.minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minbtn.Location = new System.Drawing.Point(286, 2);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(24, 24);
            this.minbtn.TabIndex = 5;
            this.minbtn.UseVisualStyleBackColor = false;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            this.minbtn.MouseEnter += new System.EventHandler(this.minbtn_MouseEnter);
            this.minbtn.MouseLeave += new System.EventHandler(this.minbtn_MouseLeave);
            this.minbtn.MouseHover += new System.EventHandler(this.minbtn_MouseHover);
            // 
            // panview
            // 
            this.panview.BackColor = System.Drawing.Color.Transparent;
            this.panview.Controls.Add(this.togglepass);
            this.panview.Controls.Add(this.loginbtn);
            this.panview.Controls.Add(this.pictureBox2);
            this.panview.Controls.Add(this.pictureBox1);
            this.panview.Controls.Add(this.passtxt);
            this.panview.Controls.Add(this.usertxt);
            this.panview.Controls.Add(this.pictureBox3);
            this.panview.Controls.Add(this.pictureBox4);
            this.panview.Controls.Add(this.pictureBox5);
            this.panview.Location = new System.Drawing.Point(0, 0);
            this.panview.Name = "panview";
            this.panview.Size = new System.Drawing.Size(384, 461);
            this.panview.TabIndex = 80;
            // 
            // togglepass
            // 
            this.togglepass.AutoSize = true;
            this.togglepass.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.togglepass.ForeColor = System.Drawing.Color.Blue;
            this.togglepass.Location = new System.Drawing.Point(95, 376);
            this.togglepass.Name = "togglepass";
            this.togglepass.Size = new System.Drawing.Size(130, 20);
            this.togglepass.TabIndex = 2;
            this.togglepass.Text = "Show Password";
            this.togglepass.UseVisualStyleBackColor = true;
            this.togglepass.CheckedChanged += new System.EventHandler(this.togglepass_CheckedChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.loginbtn.FlatAppearance.BorderSize = 2;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.Black;
            this.loginbtn.Location = new System.Drawing.Point(96, 404);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(145, 36);
            this.loginbtn.TabIndex = 3;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::EaseyBudget.Properties.Resources.password1;
            this.pictureBox2.Location = new System.Drawing.Point(38, 324);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EaseyBudget.Properties.Resources.login3;
            this.pictureBox1.Location = new System.Drawing.Point(38, 248);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // passtxt
            // 
            this.passtxt.BackColor = System.Drawing.Color.White;
            this.passtxt.BorderColor = System.Drawing.Color.Black;
            this.passtxt.BorderFocusColor = System.Drawing.Color.Blue;
            this.passtxt.BorderRadius = 1;
            this.passtxt.BorderSize = 2;
            this.passtxt.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.ForeColor = System.Drawing.Color.Black;
            this.passtxt.Location = new System.Drawing.Point(95, 331);
            this.passtxt.Margin = new System.Windows.Forms.Padding(4);
            this.passtxt.Multiline = false;
            this.passtxt.Name = "passtxt";
            this.passtxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.passtxt.PasswordChar = true;
            this.passtxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passtxt.PlaceholderText = "Password";
            this.passtxt.Size = new System.Drawing.Size(250, 38);
            this.passtxt.TabIndex = 1;
            this.passtxt.Texts = "";
            this.passtxt.UnderlinedStyle = false;
            this.passtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passtxt_KeyDown);
            this.passtxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passtxt_MouseClick);
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.Color.White;
            this.usertxt.BorderColor = System.Drawing.Color.Black;
            this.usertxt.BorderFocusColor = System.Drawing.Color.Blue;
            this.usertxt.BorderRadius = 1;
            this.usertxt.BorderSize = 2;
            this.usertxt.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.ForeColor = System.Drawing.Color.Black;
            this.usertxt.Location = new System.Drawing.Point(95, 254);
            this.usertxt.Margin = new System.Windows.Forms.Padding(4);
            this.usertxt.Multiline = false;
            this.usertxt.Name = "usertxt";
            this.usertxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.usertxt.PasswordChar = false;
            this.usertxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.usertxt.PlaceholderText = "Username";
            this.usertxt.Size = new System.Drawing.Size(250, 38);
            this.usertxt.TabIndex = 0;
            this.usertxt.Texts = "";
            this.usertxt.UnderlinedStyle = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EaseyBudget.Properties.Resources.logo_2_transparent;
            this.pictureBox3.Location = new System.Drawing.Point(30, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(326, 280);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::EaseyBudget.Properties.Resources.ff1;
            this.pictureBox4.Location = new System.Drawing.Point(0, 376);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(112, 88);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::EaseyBudget.Properties.Resources.ff2;
            this.pictureBox5.Location = new System.Drawing.Point(280, 376);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(104, 88);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.grad1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.grad1.ResumeLayout(false);
            this.accountnav.ResumeLayout(false);
            this.paneldrg.ResumeLayout(false);
            this.panview.ResumeLayout(false);
            this.panview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panview;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.RJTextBox passtxt;
        private CustomControls.RJControls.RJTextBox usertxt;
        private System.Windows.Forms.Panel paneldrg;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button minbtn;
        private System.Windows.Forms.Panel accountnav;
        private System.Windows.Forms.Button signupnav;
        private System.Windows.Forms.Button signinav;
        private System.Windows.Forms.Panel panel1;
        private Gradient grad1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox togglepass;
    }
}


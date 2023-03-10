namespace EaseyBudget
{
    partial class ViewIncome
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
            this.components = new System.ComponentModel.Container();
            this.topnav = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchnav = new System.Windows.Forms.Panel();
            this.searchnavright = new System.Windows.Forms.Panel();
            this.searchbtn2 = new System.Windows.Forms.Button();
            this.incsearch = new System.Windows.Forms.ComboBox();
            this.searchnavleft = new System.Windows.Forms.Panel();
            this.searchbox = new CustomControls.RJControls.RJTextBox();
            this.searchbtn1 = new System.Windows.Forms.Button();
            this.timenav = new System.Windows.Forms.Panel();
            this.datenav = new System.Windows.Forms.Panel();
            this.lbldate = new System.Windows.Forms.Label();
            this.daynav = new System.Windows.Forms.Panel();
            this.lblday = new System.Windows.Forms.Label();
            this.hrminav = new System.Windows.Forms.Panel();
            this.seclbl = new System.Windows.Forms.Label();
            this.minhlbl = new System.Windows.Forms.Label();
            this.ampmlbl1 = new System.Windows.Forms.Label();
            this.ampmlbl2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dbsection = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dbcell = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.topnav.SuspendLayout();
            this.searchnav.SuspendLayout();
            this.searchnavright.SuspendLayout();
            this.searchnavleft.SuspendLayout();
            this.timenav.SuspendLayout();
            this.datenav.SuspendLayout();
            this.daynav.SuspendLayout();
            this.hrminav.SuspendLayout();
            this.dbsection.SuspendLayout();
            this.SuspendLayout();
            // 
            // topnav
            // 
            this.topnav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.topnav.Controls.Add(this.label1);
            this.topnav.Dock = System.Windows.Forms.DockStyle.Top;
            this.topnav.Location = new System.Drawing.Point(0, 0);
            this.topnav.Name = "topnav";
            this.topnav.Size = new System.Drawing.Size(814, 60);
            this.topnav.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Income Details";
            // 
            // searchnav
            // 
            this.searchnav.Controls.Add(this.searchnavright);
            this.searchnav.Controls.Add(this.searchnavleft);
            this.searchnav.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchnav.Location = new System.Drawing.Point(0, 144);
            this.searchnav.Name = "searchnav";
            this.searchnav.Size = new System.Drawing.Size(814, 34);
            this.searchnav.TabIndex = 8;
            // 
            // searchnavright
            // 
            this.searchnavright.Controls.Add(this.searchbtn2);
            this.searchnavright.Controls.Add(this.incsearch);
            this.searchnavright.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchnavright.Location = new System.Drawing.Point(486, 0);
            this.searchnavright.Name = "searchnavright";
            this.searchnavright.Size = new System.Drawing.Size(328, 34);
            this.searchnavright.TabIndex = 9;
            // 
            // searchbtn2
            // 
            this.searchbtn2.BackColor = System.Drawing.Color.Transparent;
            this.searchbtn2.BackgroundImage = global::EaseyBudget.Properties.Resources.find2;
            this.searchbtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchbtn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchbtn2.FlatAppearance.BorderSize = 0;
            this.searchbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn2.Location = new System.Drawing.Point(274, 0);
            this.searchbtn2.Name = "searchbtn2";
            this.searchbtn2.Size = new System.Drawing.Size(34, 34);
            this.searchbtn2.TabIndex = 5;
            this.searchbtn2.UseVisualStyleBackColor = false;
            this.searchbtn2.MouseEnter += new System.EventHandler(this.searchbtn2_MouseEnter);
            this.searchbtn2.MouseLeave += new System.EventHandler(this.searchbtn2_MouseLeave);
            this.searchbtn2.MouseHover += new System.EventHandler(this.searchbtn2_MouseHover);
            // 
            // incsearch
            // 
            this.incsearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.incsearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.incsearch.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incsearch.FormattingEnabled = true;
            this.incsearch.Items.AddRange(new object[] {
            "Bonus",
            "Commission",
            "Tips/Gratuities",
            "Employment ",
            "Pension",
            "Social Security",
            "Others"});
            this.incsearch.Location = new System.Drawing.Point(0, 0);
            this.incsearch.Name = "incsearch";
            this.incsearch.Size = new System.Drawing.Size(255, 33);
            this.incsearch.TabIndex = 4;
            // 
            // searchnavleft
            // 
            this.searchnavleft.Controls.Add(this.searchbox);
            this.searchnavleft.Controls.Add(this.searchbtn1);
            this.searchnavleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchnavleft.Location = new System.Drawing.Point(0, 0);
            this.searchnavleft.Name = "searchnavleft";
            this.searchnavleft.Size = new System.Drawing.Size(421, 34);
            this.searchnavleft.TabIndex = 8;
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.White;
            this.searchbox.BorderColor = System.Drawing.Color.Black;
            this.searchbox.BorderFocusColor = System.Drawing.Color.Blue;
            this.searchbox.BorderRadius = 0;
            this.searchbox.BorderSize = 2;
            this.searchbox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchbox.Location = new System.Drawing.Point(19, 0);
            this.searchbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchbox.Multiline = false;
            this.searchbox.Name = "searchbox";
            this.searchbox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searchbox.PasswordChar = false;
            this.searchbox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchbox.PlaceholderText = "";
            this.searchbox.Size = new System.Drawing.Size(352, 34);
            this.searchbox.TabIndex = 3;
            this.searchbox.Texts = "";
            this.searchbox.UnderlinedStyle = false;
            // 
            // searchbtn1
            // 
            this.searchbtn1.BackColor = System.Drawing.Color.Transparent;
            this.searchbtn1.BackgroundImage = global::EaseyBudget.Properties.Resources.find1;
            this.searchbtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchbtn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchbtn1.FlatAppearance.BorderSize = 0;
            this.searchbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn1.Location = new System.Drawing.Point(385, 0);
            this.searchbtn1.Name = "searchbtn1";
            this.searchbtn1.Size = new System.Drawing.Size(34, 34);
            this.searchbtn1.TabIndex = 2;
            this.searchbtn1.UseVisualStyleBackColor = false;
            this.searchbtn1.MouseEnter += new System.EventHandler(this.searchbtn1_MouseEnter);
            this.searchbtn1.MouseLeave += new System.EventHandler(this.searchbtn1_MouseLeave);
            this.searchbtn1.MouseHover += new System.EventHandler(this.searchbtn1_MouseHover);
            // 
            // timenav
            // 
            this.timenav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.timenav.Controls.Add(this.datenav);
            this.timenav.Controls.Add(this.daynav);
            this.timenav.Controls.Add(this.hrminav);
            this.timenav.Dock = System.Windows.Forms.DockStyle.Top;
            this.timenav.Location = new System.Drawing.Point(0, 60);
            this.timenav.Name = "timenav";
            this.timenav.Size = new System.Drawing.Size(814, 74);
            this.timenav.TabIndex = 9;
            // 
            // datenav
            // 
            this.datenav.Controls.Add(this.lbldate);
            this.datenav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datenav.Location = new System.Drawing.Point(266, 0);
            this.datenav.Name = "datenav";
            this.datenav.Size = new System.Drawing.Size(370, 74);
            this.datenav.TabIndex = 2;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Myanmar Text", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lbldate.Location = new System.Drawing.Point(-1, 9);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(0, 70);
            this.lbldate.TabIndex = 4;
            // 
            // daynav
            // 
            this.daynav.Controls.Add(this.lblday);
            this.daynav.Dock = System.Windows.Forms.DockStyle.Right;
            this.daynav.Location = new System.Drawing.Point(636, 0);
            this.daynav.Name = "daynav";
            this.daynav.Size = new System.Drawing.Size(178, 74);
            this.daynav.TabIndex = 1;
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Font = new System.Drawing.Font("Myanmar Text", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblday.Location = new System.Drawing.Point(10, 17);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(0, 51);
            this.lblday.TabIndex = 5;
            // 
            // hrminav
            // 
            this.hrminav.Controls.Add(this.seclbl);
            this.hrminav.Controls.Add(this.minhlbl);
            this.hrminav.Controls.Add(this.ampmlbl1);
            this.hrminav.Controls.Add(this.ampmlbl2);
            this.hrminav.Dock = System.Windows.Forms.DockStyle.Left;
            this.hrminav.Location = new System.Drawing.Point(0, 0);
            this.hrminav.Name = "hrminav";
            this.hrminav.Size = new System.Drawing.Size(266, 74);
            this.hrminav.TabIndex = 0;
            // 
            // seclbl
            // 
            this.seclbl.AutoSize = true;
            this.seclbl.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seclbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.seclbl.Location = new System.Drawing.Point(134, 25);
            this.seclbl.Name = "seclbl";
            this.seclbl.Size = new System.Drawing.Size(0, 48);
            this.seclbl.TabIndex = 3;
            // 
            // minhlbl
            // 
            this.minhlbl.AutoSize = true;
            this.minhlbl.Font = new System.Drawing.Font("Myanmar Text", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minhlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.minhlbl.Location = new System.Drawing.Point(3, 3);
            this.minhlbl.Name = "minhlbl";
            this.minhlbl.Size = new System.Drawing.Size(0, 85);
            this.minhlbl.TabIndex = 2;
            // 
            // ampmlbl1
            // 
            this.ampmlbl1.AutoSize = true;
            this.ampmlbl1.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ampmlbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ampmlbl1.Location = new System.Drawing.Point(190, 3);
            this.ampmlbl1.Name = "ampmlbl1";
            this.ampmlbl1.Size = new System.Drawing.Size(50, 37);
            this.ampmlbl1.TabIndex = 0;
            this.ampmlbl1.Text = "AM";
            // 
            // ampmlbl2
            // 
            this.ampmlbl2.AutoSize = true;
            this.ampmlbl2.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ampmlbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ampmlbl2.Location = new System.Drawing.Point(190, 40);
            this.ampmlbl2.Name = "ampmlbl2";
            this.ampmlbl2.Size = new System.Drawing.Size(48, 37);
            this.ampmlbl2.TabIndex = 1;
            this.ampmlbl2.Text = "PM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(227)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 10);
            this.panel1.TabIndex = 10;
            // 
            // dbsection
            // 
            this.dbsection.Controls.Add(this.panel5);
            this.dbsection.Controls.Add(this.panel4);
            this.dbsection.Controls.Add(this.panel3);
            this.dbsection.Controls.Add(this.dbcell);
            this.dbsection.Controls.Add(this.panel2);
            this.dbsection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbsection.Location = new System.Drawing.Point(0, 178);
            this.dbsection.Name = "dbsection";
            this.dbsection.Size = new System.Drawing.Size(814, 393);
            this.dbsection.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(20, 373);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(774, 20);
            this.panel5.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(794, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 373);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 373);
            this.panel3.TabIndex = 3;
            // 
            // dbcell
            // 
            this.dbcell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.dbcell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbcell.Location = new System.Drawing.Point(0, 20);
            this.dbcell.Name = "dbcell";
            this.dbcell.Size = new System.Drawing.Size(814, 373);
            this.dbcell.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 20);
            this.panel2.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ViewIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(814, 571);
            this.Controls.Add(this.dbsection);
            this.Controls.Add(this.searchnav);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.timenav);
            this.Controls.Add(this.topnav);
            this.Name = "ViewIncome";
            this.Text = "ViewIncome";
            this.Load += new System.EventHandler(this.ViewIncome_Load);
            this.topnav.ResumeLayout(false);
            this.topnav.PerformLayout();
            this.searchnav.ResumeLayout(false);
            this.searchnavright.ResumeLayout(false);
            this.searchnavleft.ResumeLayout(false);
            this.timenav.ResumeLayout(false);
            this.datenav.ResumeLayout(false);
            this.datenav.PerformLayout();
            this.daynav.ResumeLayout(false);
            this.daynav.PerformLayout();
            this.hrminav.ResumeLayout(false);
            this.hrminav.PerformLayout();
            this.dbsection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topnav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel searchnav;
        private System.Windows.Forms.Panel searchnavright;
        private System.Windows.Forms.Button searchbtn2;
        private System.Windows.Forms.ComboBox incsearch;
        private System.Windows.Forms.Panel searchnavleft;
        private CustomControls.RJControls.RJTextBox searchbox;
        private System.Windows.Forms.Button searchbtn1;
        private System.Windows.Forms.Panel timenav;
        private System.Windows.Forms.Panel datenav;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Panel daynav;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Panel hrminav;
        private System.Windows.Forms.Label seclbl;
        private System.Windows.Forms.Label minhlbl;
        private System.Windows.Forms.Label ampmlbl1;
        private System.Windows.Forms.Label ampmlbl2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel dbsection;
        private System.Windows.Forms.Panel dbcell;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer;
    }
}
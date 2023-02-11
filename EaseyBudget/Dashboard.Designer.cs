namespace EaseyBudget
{
    partial class Dashboard
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
            this.paneldrg = new System.Windows.Forms.Panel();
            this.exitbtn = new System.Windows.Forms.Button();
            this.minbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.formview = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.expstat = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalinc = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.incstat = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totalexp = new System.Windows.Forms.GroupBox();
            this.leftnav = new System.Windows.Forms.Panel();
            this.btnav = new System.Windows.Forms.Panel();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.incomebtn = new System.Windows.Forms.Button();
            this.expensebtn = new System.Windows.Forms.Button();
            this.dashbtn = new System.Windows.Forms.Button();
            this.logonav = new System.Windows.Forms.Panel();
            this.logo1 = new System.Windows.Forms.PictureBox();
            this.paneldrg.SuspendLayout();
            this.formview.SuspendLayout();
            this.panel1.SuspendLayout();
            this.expstat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.incstat.SuspendLayout();
            this.leftnav.SuspendLayout();
            this.btnav.SuspendLayout();
            this.logonav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldrg
            // 
            this.paneldrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(227)))));
            this.paneldrg.Controls.Add(this.exitbtn);
            this.paneldrg.Controls.Add(this.minbtn);
            this.paneldrg.Controls.Add(this.label1);
            this.paneldrg.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneldrg.Location = new System.Drawing.Point(231, 0);
            this.paneldrg.Name = "paneldrg";
            this.paneldrg.Size = new System.Drawing.Size(803, 52);
            this.paneldrg.TabIndex = 1;
            this.paneldrg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneldrg_MouseDown);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.BackgroundImage = global::EaseyBudget.Properties.Resources.exit1;
            this.exitbtn.FlatAppearance.BorderSize = 0;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Location = new System.Drawing.Point(772, 3);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(24, 24);
            this.exitbtn.TabIndex = 3;
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
            this.minbtn.Location = new System.Drawing.Point(704, 3);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(24, 24);
            this.minbtn.TabIndex = 2;
            this.minbtn.UseVisualStyleBackColor = false;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            this.minbtn.MouseEnter += new System.EventHandler(this.minbtn_MouseEnter);
            this.minbtn.MouseLeave += new System.EventHandler(this.minbtn_MouseLeave);
            this.minbtn.MouseHover += new System.EventHandler(this.minbtn_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "EaseyBudget: Personal Finance Managing App";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // formview
            // 
            this.formview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(227)))));
            this.formview.Controls.Add(this.panel1);
            this.formview.Controls.Add(this.expstat);
            this.formview.Controls.Add(this.groupBox1);
            this.formview.Controls.Add(this.totalinc);
            this.formview.Controls.Add(this.groupBox2);
            this.formview.Controls.Add(this.incstat);
            this.formview.Controls.Add(this.totalexp);
            this.formview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formview.Location = new System.Drawing.Point(231, 52);
            this.formview.Name = "formview";
            this.formview.Size = new System.Drawing.Size(803, 569);
            this.formview.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label18);
            this.panel1.Location = new System.Drawing.Point(344, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 210);
            this.panel1.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(192, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Features TBD";
            // 
            // expstat
            // 
            this.expstat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.expstat.Controls.Add(this.label11);
            this.expstat.Controls.Add(this.label10);
            this.expstat.Controls.Add(this.label3);
            this.expstat.Controls.Add(this.label2);
            this.expstat.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expstat.Location = new System.Drawing.Point(344, 400);
            this.expstat.Name = "expstat";
            this.expstat.Size = new System.Drawing.Size(221, 155);
            this.expstat.TabIndex = 2;
            this.expstat.TabStop = false;
            this.expstat.Text = "Expense Status";
            this.expstat.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label11.Location = new System.Drawing.Point(6, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "VALUE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label10.Location = new System.Drawing.Point(6, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "VALUE ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Maximum Expense Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Minimum Expense Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(344, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Latest Expense Record";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "MM-DD-YYYY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "VALUE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Date Recorded";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount:";
            // 
            // totalinc
            // 
            this.totalinc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.totalinc.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalinc.Location = new System.Drawing.Point(18, 288);
            this.totalinc.Name = "totalinc";
            this.totalinc.Size = new System.Drawing.Size(310, 267);
            this.totalinc.TabIndex = 1;
            this.totalinc.TabStop = false;
            this.totalinc.Text = "Total Income";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(576, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 155);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Latest Income Record";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label14.Location = new System.Drawing.Point(6, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 15);
            this.label14.TabIndex = 7;
            this.label14.Text = "MM-DD-YYYY";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label15.Location = new System.Drawing.Point(6, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "VALUE";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "Date Recorded";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 15);
            this.label17.TabIndex = 4;
            this.label17.Text = "Amount:";
            // 
            // incstat
            // 
            this.incstat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.incstat.Controls.Add(this.label13);
            this.incstat.Controls.Add(this.label12);
            this.incstat.Controls.Add(this.label6);
            this.incstat.Controls.Add(this.label7);
            this.incstat.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incstat.Location = new System.Drawing.Point(576, 400);
            this.incstat.Name = "incstat";
            this.incstat.Size = new System.Drawing.Size(221, 155);
            this.incstat.TabIndex = 4;
            this.incstat.TabStop = false;
            this.incstat.Text = "Income Status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label13.Location = new System.Drawing.Point(6, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "VALUE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label12.Location = new System.Drawing.Point(6, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "VALUE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Maximum Income Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Minimum Income Amount";
            // 
            // totalexp
            // 
            this.totalexp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.totalexp.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalexp.Location = new System.Drawing.Point(18, 6);
            this.totalexp.Name = "totalexp";
            this.totalexp.Size = new System.Drawing.Size(310, 265);
            this.totalexp.TabIndex = 0;
            this.totalexp.TabStop = false;
            this.totalexp.Text = "Total Expense";
            // 
            // leftnav
            // 
            this.leftnav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(226)))), ((int)(((byte)(198)))));
            this.leftnav.Controls.Add(this.btnav);
            this.leftnav.Controls.Add(this.logonav);
            this.leftnav.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftnav.Location = new System.Drawing.Point(0, 0);
            this.leftnav.Name = "leftnav";
            this.leftnav.Size = new System.Drawing.Size(231, 621);
            this.leftnav.TabIndex = 0;
            // 
            // btnav
            // 
            this.btnav.Controls.Add(this.logoutbtn);
            this.btnav.Controls.Add(this.incomebtn);
            this.btnav.Controls.Add(this.expensebtn);
            this.btnav.Controls.Add(this.dashbtn);
            this.btnav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnav.Location = new System.Drawing.Point(0, 160);
            this.btnav.Name = "btnav";
            this.btnav.Size = new System.Drawing.Size(231, 461);
            this.btnav.TabIndex = 2;
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutbtn.FlatAppearance.BorderSize = 0;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.Location = new System.Drawing.Point(0, 396);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(231, 65);
            this.logoutbtn.TabIndex = 3;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            this.logoutbtn.MouseEnter += new System.EventHandler(this.logoutbtn_MouseEnter);
            this.logoutbtn.MouseLeave += new System.EventHandler(this.logoutbtn_MouseLeave);
            this.logoutbtn.MouseHover += new System.EventHandler(this.logoutbtn_MouseHover);
            // 
            // incomebtn
            // 
            this.incomebtn.BackColor = System.Drawing.Color.Transparent;
            this.incomebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.incomebtn.FlatAppearance.BorderSize = 0;
            this.incomebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomebtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomebtn.Location = new System.Drawing.Point(0, 130);
            this.incomebtn.Name = "incomebtn";
            this.incomebtn.Size = new System.Drawing.Size(231, 65);
            this.incomebtn.TabIndex = 2;
            this.incomebtn.Text = "Income";
            this.incomebtn.UseVisualStyleBackColor = false;
            this.incomebtn.Click += new System.EventHandler(this.incomebtn_Click);
            this.incomebtn.MouseEnter += new System.EventHandler(this.incomebtn_MouseEnter);
            this.incomebtn.MouseLeave += new System.EventHandler(this.incomebtn_MouseLeave);
            this.incomebtn.MouseHover += new System.EventHandler(this.incomebtn_MouseHover);
            // 
            // expensebtn
            // 
            this.expensebtn.BackColor = System.Drawing.Color.Transparent;
            this.expensebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.expensebtn.FlatAppearance.BorderSize = 0;
            this.expensebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expensebtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expensebtn.Location = new System.Drawing.Point(0, 65);
            this.expensebtn.Name = "expensebtn";
            this.expensebtn.Size = new System.Drawing.Size(231, 65);
            this.expensebtn.TabIndex = 1;
            this.expensebtn.Text = "Expense";
            this.expensebtn.UseVisualStyleBackColor = false;
            this.expensebtn.Click += new System.EventHandler(this.expensebtn_Click);
            this.expensebtn.MouseEnter += new System.EventHandler(this.expensebtn_MouseEnter);
            this.expensebtn.MouseLeave += new System.EventHandler(this.expensebtn_MouseLeave);
            this.expensebtn.MouseHover += new System.EventHandler(this.expensebtn_MouseHover);
            // 
            // dashbtn
            // 
            this.dashbtn.BackColor = System.Drawing.Color.Transparent;
            this.dashbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashbtn.FlatAppearance.BorderSize = 0;
            this.dashbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashbtn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbtn.Location = new System.Drawing.Point(0, 0);
            this.dashbtn.Name = "dashbtn";
            this.dashbtn.Size = new System.Drawing.Size(231, 65);
            this.dashbtn.TabIndex = 0;
            this.dashbtn.Text = "Dashboard";
            this.dashbtn.UseVisualStyleBackColor = false;
            this.dashbtn.Click += new System.EventHandler(this.dashbtn_Click);
            this.dashbtn.MouseEnter += new System.EventHandler(this.dashbtn_MouseEnter);
            this.dashbtn.MouseLeave += new System.EventHandler(this.dashbtn_MouseLeave);
            this.dashbtn.MouseHover += new System.EventHandler(this.dashbtn_MouseHover);
            // 
            // logonav
            // 
            this.logonav.Controls.Add(this.logo1);
            this.logonav.Dock = System.Windows.Forms.DockStyle.Top;
            this.logonav.Location = new System.Drawing.Point(0, 0);
            this.logonav.Name = "logonav";
            this.logonav.Size = new System.Drawing.Size(231, 160);
            this.logonav.TabIndex = 0;
            // 
            // logo1
            // 
            this.logo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo1.Image = global::EaseyBudget.Properties.Resources.logo_1_transparent;
            this.logo1.Location = new System.Drawing.Point(0, 0);
            this.logo1.Name = "logo1";
            this.logo1.Size = new System.Drawing.Size(231, 160);
            this.logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo1.TabIndex = 0;
            this.logo1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(209)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1034, 621);
            this.Controls.Add(this.formview);
            this.Controls.Add(this.paneldrg);
            this.Controls.Add(this.leftnav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.paneldrg.ResumeLayout(false);
            this.paneldrg.PerformLayout();
            this.formview.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.expstat.ResumeLayout(false);
            this.expstat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.incstat.ResumeLayout(false);
            this.incstat.PerformLayout();
            this.leftnav.ResumeLayout(false);
            this.btnav.ResumeLayout(false);
            this.logonav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftnav;
        private System.Windows.Forms.Panel paneldrg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Panel btnav;
        private System.Windows.Forms.Button dashbtn;
        private System.Windows.Forms.Panel logonav;
        private System.Windows.Forms.Button expensebtn;
        private System.Windows.Forms.Button incomebtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Panel formview;
        private System.Windows.Forms.PictureBox logo1;
        private System.Windows.Forms.GroupBox totalinc;
        private System.Windows.Forms.GroupBox totalexp;
        private System.Windows.Forms.GroupBox expstat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox incstat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
    }
}
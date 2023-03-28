﻿namespace EaseyBudget
{
    partial class Expense
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.locoftrans = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.detailstxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.amountxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.expcategory = new System.Windows.Forms.ComboBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gmappanel = new System.Windows.Forms.Panel();
            this.gmapbg = new System.Windows.Forms.PictureBox();
            this.googleweb = new System.Windows.Forms.WebBrowser();
            this.proceedbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gmappanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gmapbg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(207)))), ((int)(((byte)(190)))));
            this.groupBox1.Controls.Add(this.proceedbtn);
            this.groupBox1.Controls.Add(this.clearbtn);
            this.groupBox1.Controls.Add(this.searchbtn);
            this.groupBox1.Controls.Add(this.locoftrans);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.detailstxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.amountxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.expcategory);
            this.groupBox1.Controls.Add(this.nametxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 530);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expense Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbtn.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(11, 312);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(56, 23);
            this.searchbtn.TabIndex = 4;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // locoftrans
            // 
            this.locoftrans.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locoftrans.Location = new System.Drawing.Point(11, 272);
            this.locoftrans.Name = "locoftrans";
            this.locoftrans.Size = new System.Drawing.Size(264, 27);
            this.locoftrans.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Location of Transaction:";
            // 
            // detailstxt
            // 
            this.detailstxt.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailstxt.Location = new System.Drawing.Point(11, 376);
            this.detailstxt.Multiline = true;
            this.detailstxt.Name = "detailstxt";
            this.detailstxt.Size = new System.Drawing.Size(264, 112);
            this.detailstxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Additional Details";
            // 
            // amountxt
            // 
            this.amountxt.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountxt.Location = new System.Drawing.Point(11, 200);
            this.amountxt.Name = "amountxt";
            this.amountxt.Size = new System.Drawing.Size(179, 27);
            this.amountxt.TabIndex = 2;
            this.amountxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Expense Amount:";
            // 
            // expcategory
            // 
            this.expcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.expcategory.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expcategory.FormattingEnabled = true;
            this.expcategory.Items.AddRange(new object[] {
            "Clothing/Accessories",
            "Housing",
            "Transportation",
            "Taxes",
            "Debt payments",
            "Insurance",
            "Others"});
            this.expcategory.Location = new System.Drawing.Point(11, 128);
            this.expcategory.Name = "expcategory";
            this.expcategory.Size = new System.Drawing.Size(216, 27);
            this.expcategory.TabIndex = 1;
            this.expcategory.SelectedIndexChanged += new System.EventHandler(this.expcategory_SelectedIndexChanged);
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(11, 56);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(216, 27);
            this.nametxt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name of Expense";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Type";
            // 
            // gmappanel
            // 
            this.gmappanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(227)))));
            this.gmappanel.Controls.Add(this.gmapbg);
            this.gmappanel.Controls.Add(this.googleweb);
            this.gmappanel.Location = new System.Drawing.Point(312, 8);
            this.gmappanel.Name = "gmappanel";
            this.gmappanel.Size = new System.Drawing.Size(485, 530);
            this.gmappanel.TabIndex = 12;
            // 
            // gmapbg
            // 
            this.gmapbg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmapbg.Image = global::EaseyBudget.Properties.Resources._1200x630wa;
            this.gmapbg.Location = new System.Drawing.Point(0, 0);
            this.gmapbg.Name = "gmapbg";
            this.gmapbg.Size = new System.Drawing.Size(485, 530);
            this.gmapbg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gmapbg.TabIndex = 1;
            this.gmapbg.TabStop = false;
            // 
            // googleweb
            // 
            this.googleweb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.googleweb.Location = new System.Drawing.Point(0, 0);
            this.googleweb.MinimumSize = new System.Drawing.Size(20, 20);
            this.googleweb.Name = "googleweb";
            this.googleweb.Size = new System.Drawing.Size(485, 530);
            this.googleweb.TabIndex = 0;
            // 
            // proceedbtn
            // 
            this.proceedbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.proceedbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.proceedbtn.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedbtn.Location = new System.Drawing.Point(12, 502);
            this.proceedbtn.Name = "proceedbtn";
            this.proceedbtn.Size = new System.Drawing.Size(79, 23);
            this.proceedbtn.TabIndex = 0;
            this.proceedbtn.Text = "Proceed";
            this.proceedbtn.UseVisualStyleBackColor = false;
            this.proceedbtn.Click += new System.EventHandler(this.proceedbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearbtn.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.Location = new System.Drawing.Point(96, 502);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(79, 23);
            this.clearbtn.TabIndex = 10;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(236)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(814, 561);
            this.Controls.Add(this.gmappanel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Expense";
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.Expense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gmappanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gmapbg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox detailstxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amountxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox expcategory;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox locoftrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel gmappanel;
        private System.Windows.Forms.Button proceedbtn;
        private System.Windows.Forms.WebBrowser googleweb;
        private System.Windows.Forms.PictureBox gmapbg;
        private System.Windows.Forms.Button clearbtn;
    }
}
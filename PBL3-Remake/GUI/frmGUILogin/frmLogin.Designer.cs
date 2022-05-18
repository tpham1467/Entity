﻿namespace PBL3_Remake.GUI.frmGUILogin
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radManager = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radEmployee = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnConnectToDataBase = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pBLogin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(46, 242);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(46, 302);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(310, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // radManager
            // 
            this.radManager.AutoSize = true;
            this.radManager.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radManager.ForeColor = System.Drawing.Color.White;
            this.radManager.Location = new System.Drawing.Point(3, 9);
            this.radManager.Name = "radManager";
            this.radManager.Size = new System.Drawing.Size(84, 27);
            this.radManager.TabIndex = 6;
            this.radManager.TabStop = true;
            this.radManager.Text = "Manager";
            this.radManager.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radEmployee);
            this.panel1.Controls.Add(this.radManager);
            this.panel1.Location = new System.Drawing.Point(46, 330);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 70);
            this.panel1.TabIndex = 7;
            // 
            // radEmployee
            // 
            this.radEmployee.AutoSize = true;
            this.radEmployee.Font = new System.Drawing.Font("Myanmar Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEmployee.ForeColor = System.Drawing.Color.White;
            this.radEmployee.Location = new System.Drawing.Point(3, 34);
            this.radEmployee.Name = "radEmployee";
            this.radEmployee.Size = new System.Drawing.Size(88, 27);
            this.radEmployee.TabIndex = 7;
            this.radEmployee.TabStop = true;
            this.radEmployee.Text = "Employee";
            this.radEmployee.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Image = global::PBL3_Remake.Properties.Resources.key_32;
            this.btnLogin.Location = new System.Drawing.Point(185, 388);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(50, 50);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnConnectToDataBase
            // 
            this.btnConnectToDataBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnConnectToDataBase.FlatAppearance.BorderSize = 0;
            this.btnConnectToDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectToDataBase.Image = global::PBL3_Remake.Properties.Resources.cloud_database_32;
            this.btnConnectToDataBase.Location = new System.Drawing.Point(355, 555);
            this.btnConnectToDataBase.Name = "btnConnectToDataBase";
            this.btnConnectToDataBase.Size = new System.Drawing.Size(33, 33);
            this.btnConnectToDataBase.TabIndex = 11;
            this.btnConnectToDataBase.UseVisualStyleBackColor = false;
            this.btnConnectToDataBase.Click += new System.EventHandler(this.btnConnectToDataBase_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::PBL3_Remake.Properties.Resources.shutdown_32;
            this.btnExit.Location = new System.Drawing.Point(13, 555);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 33);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pBLogin
            // 
            this.pBLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBLogin.Image = global::PBL3_Remake.Properties.Resources.LoginImage;
            this.pBLogin.Location = new System.Drawing.Point(394, 0);
            this.pBLogin.Name = "pBLogin";
            this.pBLogin.Size = new System.Drawing.Size(388, 600);
            this.pBLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBLogin.TabIndex = 0;
            this.pBLogin.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(782, 600);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnConnectToDataBase);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radEmployee;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConnectToDataBase;
        private System.Windows.Forms.Button btnLogin;
    }
}
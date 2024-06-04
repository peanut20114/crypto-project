namespace ProjectGUI
{
    partial class Sign_In
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lb_SignUp = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(132, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN IN\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ProjectGUI.Properties.Resources.bg3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(58, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 64);
            this.panel1.TabIndex = 2;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.DimGray;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_username.Location = new System.Drawing.Point(66, 14);
            this.tb_username.Margin = new System.Windows.Forms.Padding(7);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(245, 27);
            this.tb_username.TabIndex = 1;
            this.tb_username.Text = "Type your username";
            this.tb_username.Click += new System.EventHandler(this.tb_username_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectGUI.Properties.Resources.icon_user_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(53, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::ProjectGUI.Properties.Resources.bg3;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.tb_password);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(58, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 64);
            this.panel2.TabIndex = 4;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.DimGray;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_password.Location = new System.Drawing.Point(66, 14);
            this.tb_password.Margin = new System.Windows.Forms.Padding(7);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(245, 27);
            this.tb_password.TabIndex = 1;
            this.tb_password.Text = "Type your password";
            this.tb_password.Click += new System.EventHandler(this.tb_password_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectGUI.Properties.Resources.icon_user_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(53, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DimGray;
            this.btn_login.BackgroundImage = global::ProjectGUI.Properties.Resources.bg3;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Transparent;
            this.btn_login.Location = new System.Drawing.Point(273, 463);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(114, 45);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "LOG IN";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // lb_SignUp
            // 
            this.lb_SignUp.AutoSize = true;
            this.lb_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.lb_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SignUp.LinkColor = System.Drawing.SystemColors.Info;
            this.lb_SignUp.Location = new System.Drawing.Point(67, 463);
            this.lb_SignUp.Name = "lb_SignUp";
            this.lb_SignUp.Size = new System.Drawing.Size(144, 20);
            this.lb_SignUp.TabIndex = 6;
            this.lb_SignUp.TabStop = true;
            this.lb_SignUp.Text = "Sign up account";
            this.lb_SignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_SignUp_LinkClicked);
            // 
            // Sign_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectGUI.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 721);
            this.Controls.Add(this.lb_SignUp);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Sign_In";
            this.Text = "Sign in";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel lb_SignUp;
    }
}


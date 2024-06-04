namespace ProjectGUI
{
    partial class Sign_Up
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_fullName = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ProjectGUI.Properties.Resources.bg3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(45, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 64);
            this.panel1.TabIndex = 3;
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
            this.tb_username.Size = new System.Drawing.Size(258, 27);
            this.tb_username.TabIndex = 1;
            this.tb_username.Text = "Type username";
            this.tb_username.Click += new System.EventHandler(this.tb_username_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectGUI.Properties.Resources.icon_user_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(148, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "SIGN UP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::ProjectGUI.Properties.Resources.bg3;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.tb_password);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(45, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 64);
            this.panel2.TabIndex = 5;
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
            this.tb_password.Size = new System.Drawing.Size(258, 27);
            this.tb_password.TabIndex = 1;
            this.tb_password.Text = "Type password";
            this.tb_password.Click += new System.EventHandler(this.tb_password_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectGUI.Properties.Resources.icon_pass;
            this.pictureBox2.Location = new System.Drawing.Point(12, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::ProjectGUI.Properties.Resources.bg3;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.tb_fullName);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(45, 313);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 64);
            this.panel3.TabIndex = 6;
            // 
            // tb_fullName
            // 
            this.tb_fullName.BackColor = System.Drawing.Color.DimGray;
            this.tb_fullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_fullName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fullName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_fullName.Location = new System.Drawing.Point(66, 14);
            this.tb_fullName.Margin = new System.Windows.Forms.Padding(7);
            this.tb_fullName.Name = "tb_fullName";
            this.tb_fullName.Size = new System.Drawing.Size(258, 27);
            this.tb_fullName.TabIndex = 1;
            this.tb_fullName.Text = "Type FullName";
            this.tb_fullName.Click += new System.EventHandler(this.tb_fullName_Click);
            this.tb_fullName.TextChanged += new System.EventHandler(this.tb_fullName_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjectGUI.Properties.Resources.id_icon1;
            this.pictureBox3.Location = new System.Drawing.Point(12, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.DimGray;
            this.btn_register.BackgroundImage = global::ProjectGUI.Properties.Resources.bg3;
            this.btn_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_register.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.Transparent;
            this.btn_register.Location = new System.Drawing.Point(297, 561);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(114, 45);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "REGISTER";
            this.btn_register.UseVisualStyleBackColor = false;
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectGUI.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(461, 804);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Sign_Up";
            this.Text = "Sign_Up";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_fullName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_register;
    }
}
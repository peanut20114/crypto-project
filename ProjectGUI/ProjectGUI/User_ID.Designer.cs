namespace ProjectGUI
{
    partial class User_ID
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjectGUI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(213, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(170, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "FIND USER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ProjectGUI.Properties.Resources.bg3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tb_username);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(118, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 64);
            this.panel1.TabIndex = 4;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectGUI.Properties.Resources.icon_user_1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::ProjectGUI.Properties.Resources.bg3;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.tb_ID);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(118, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 64);
            this.panel2.TabIndex = 5;
            // 
            // tb_ID
            // 
            this.tb_ID.BackColor = System.Drawing.Color.DimGray;
            this.tb_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_ID.Location = new System.Drawing.Point(66, 14);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(7);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(258, 27);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.Text = "Type ID";
            this.tb_ID.Click += new System.EventHandler(this.tb_ID_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProjectGUI.Properties.Resources.id_icon2;
            this.pictureBox3.Location = new System.Drawing.Point(12, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.DimGray;
            this.btn_send.BackgroundImage = global::ProjectGUI.Properties.Resources.bg3;
            this.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_send.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.Transparent;
            this.btn_send.Location = new System.Drawing.Point(370, 421);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(114, 45);
            this.btn_send.TabIndex = 8;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = false;
            // 
            // User_ID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectGUI.Properties.Resources.user_information_BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 561);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Name = "User_ID";
            this.Text = "User_ID";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_send;
    }
}
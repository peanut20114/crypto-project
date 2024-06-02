namespace crypto_project
{
    partial class UserID
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            ID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            key_d = new TextBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            this.btnSend = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo1;
            pictureBox1.Location = new Point(127, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(ID);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(55, 324);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 74);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.id_icon;
            pictureBox2.Location = new Point(14, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // ID
            // 
            ID.BackColor = Color.DimGray;
            ID.BorderStyle = BorderStyle.None;
            ID.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ID.ForeColor = Color.Gainsboro;
            ID.Location = new Point(82, 18);
            ID.Name = "ID";
            ID.Size = new Size(257, 31);
            ID.TabIndex = 1;
            ID.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(55, 294);
            label1.Name = "label1";
            label1.Size = new Size(82, 27);
            label1.TabIndex = 2;
            label1.Text = "User ID";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(key_d);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(55, 445);
            panel2.Name = "panel2";
            panel2.Size = new Size(355, 74);
            panel2.TabIndex = 3;
            // 
            // key_d
            // 
            key_d.BackColor = Color.DimGray;
            key_d.BorderStyle = BorderStyle.None;
            key_d.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            key_d.ForeColor = Color.Gainsboro;
            key_d.Location = new Point(82, 18);
            key_d.Name = "key_d";
            key_d.Size = new Size(257, 31);
            key_d.TabIndex = 1;
            key_d.Text = "Private Key (d)";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.key__icon;
            pictureBox3.Location = new Point(14, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(58, 415);
            label2.Name = "label2";
            label2.Size = new Size(153, 27);
            label2.TabIndex = 4;
            label2.Text = "Private Key (d)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft YaHei", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(127, 200);
            label3.Name = "label3";
            label3.Size = new Size(224, 50);
            label3.TabIndex = 2;
            label3.Text = "FIND USER";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = Color.Gray;
            this.btnSend.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnSend.ForeColor = Color.WhiteSmoke;
            this.btnSend.Location = new Point(137, 576);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new Size(163, 56);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // UserID
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.user_information_BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(450, 747);
            Controls.Add(this.btnSend);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "UserID";
            Text = "UserID";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox ID;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel2;
        private TextBox key_d;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
    }
}
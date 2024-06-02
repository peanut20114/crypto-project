namespace crypto_project
{
    partial class PrivateKey
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
            label1 = new Label();
            panel2 = new Panel();
            key_d = new TextBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            btn_send = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo1;
            pictureBox1.Location = new Point(43, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(194, 49);
            label1.Name = "label1";
            label1.Size = new Size(336, 62);
            label1.TabIndex = 1;
            label1.Text = "PRIVATE KEY";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(key_d);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(85, 266);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 74);
            panel2.TabIndex = 4;
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
            label2.Location = new Point(85, 224);
            label2.Name = "label2";
            label2.Size = new Size(153, 27);
            label2.TabIndex = 5;
            label2.Text = "Private Key (d)";
            // 
            // btn_send
            // 
            btn_send.BackColor = Color.Gray;
            btn_send.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_send.ForeColor = Color.WhiteSmoke;
            btn_send.Location = new Point(243, 386);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(163, 56);
            btn_send.TabIndex = 6;
            btn_send.Text = "SEND";
            btn_send.UseVisualStyleBackColor = false;
            // 
            // PrivateKey
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.user_information_BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(627, 478);
            Controls.Add(btn_send);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PrivateKey";
            Text = "PrivateKey";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private TextBox key_d;
        private PictureBox pictureBox3;
        private Label label2;
        private Button btn_send;
    }
}
namespace ProjectGUI
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_pKey = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjectGUI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(230, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 113);
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
            this.label1.Location = new System.Drawing.Point(167, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRIVATE KEY";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ProjectGUI.Properties.Resources.bg3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tb_pKey);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(119, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 64);
            this.panel1.TabIndex = 5;
            // 
            // tb_pKey
            // 
            this.tb_pKey.BackColor = System.Drawing.Color.DimGray;
            this.tb_pKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pKey.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pKey.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_pKey.Location = new System.Drawing.Point(66, 14);
            this.tb_pKey.Margin = new System.Windows.Forms.Padding(7);
            this.tb_pKey.Name = "tb_pKey";
            this.tb_pKey.Size = new System.Drawing.Size(258, 27);
            this.tb_pKey.TabIndex = 1;
            this.tb_pKey.Text = "Type private key";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectGUI.Properties.Resources.key__icon;
            this.pictureBox2.Location = new System.Drawing.Point(23, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.DimGray;
            this.btn_send.BackgroundImage = global::ProjectGUI.Properties.Resources.bg3;
            this.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_send.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.Color.Transparent;
            this.btn_send.Location = new System.Drawing.Point(371, 326);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(114, 45);
            this.btn_send.TabIndex = 9;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = false;
            // 
            // PrivateKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectGUI.Properties.Resources.user_information_BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(587, 478);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PrivateKey";
            this.Text = "PrivateKey";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_pKey;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_send;
    }
}
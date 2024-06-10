﻿namespace ProjectGUI
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lv_listVideos = new System.Windows.Forms.ListView();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_download = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_share = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.btn_selectAll = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_copyID = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.User.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Main);
            this.tabControl1.Controls.Add(this.User);
            this.tabControl1.Location = new System.Drawing.Point(35, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1046, 673);
            this.tabControl1.TabIndex = 0;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.splitContainer1);
            this.Main.Location = new System.Drawing.Point(4, 25);
            this.Main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1038, 644);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lv_listVideos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.splitContainer1.Panel2.Controls.Add(this.btn_download);
            this.splitContainer1.Panel2.Controls.Add(this.btn_upload);
            this.splitContainer1.Panel2.Controls.Add(this.btn_share);
            this.splitContainer1.Panel2.Controls.Add(this.btn_decrypt);
            this.splitContainer1.Panel2.Controls.Add(this.btn_selectAll);
            this.splitContainer1.Panel2.Controls.Add(this.btn_reload);
            this.splitContainer1.Size = new System.Drawing.Size(1038, 644);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 0;
            // 
            // lv_listVideos
            // 
            this.lv_listVideos.HideSelection = false;
            this.lv_listVideos.Location = new System.Drawing.Point(3, 1);
            this.lv_listVideos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_listVideos.Name = "lv_listVideos";
            this.lv_listVideos.Size = new System.Drawing.Size(357, 656);
            this.lv_listVideos.TabIndex = 0;
            this.lv_listVideos.UseCompatibleStateImageBehavior = false;
            this.lv_listVideos.View = System.Windows.Forms.View.Tile;
            this.lv_listVideos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_listVideos_MouseDoubleClick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 126);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(459, 329);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            // 
            // btn_download
            // 
            this.btn_download.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_download.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_download.Location = new System.Drawing.Point(459, 4);
            this.btn_download.Margin = new System.Windows.Forms.Padding(0);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(137, 91);
            this.btn_download.TabIndex = 5;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = false;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_upload.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Location = new System.Drawing.Point(318, 4);
            this.btn_upload.Margin = new System.Windows.Forms.Padding(0);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(141, 91);
            this.btn_upload.TabIndex = 4;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_share
            // 
            this.btn_share.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_share.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_share.Location = new System.Drawing.Point(215, 63);
            this.btn_share.Margin = new System.Windows.Forms.Padding(0);
            this.btn_share.Name = "btn_share";
            this.btn_share.Size = new System.Drawing.Size(88, 32);
            this.btn_share.TabIndex = 3;
            this.btn_share.Text = "Share";
            this.btn_share.UseVisualStyleBackColor = false;
            this.btn_share.Click += new System.EventHandler(this.btn_share_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_decrypt.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decrypt.Location = new System.Drawing.Point(92, 63);
            this.btn_decrypt.Margin = new System.Windows.Forms.Padding(0);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(123, 32);
            this.btn_decrypt.TabIndex = 2;
            this.btn_decrypt.Text = "Play Video";
            this.btn_decrypt.UseVisualStyleBackColor = false;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // btn_selectAll
            // 
            this.btn_selectAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_selectAll.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectAll.Location = new System.Drawing.Point(3, 63);
            this.btn_selectAll.Margin = new System.Windows.Forms.Padding(0);
            this.btn_selectAll.Name = "btn_selectAll";
            this.btn_selectAll.Size = new System.Drawing.Size(89, 32);
            this.btn_selectAll.TabIndex = 1;
            this.btn_selectAll.Text = "Select all";
            this.btn_selectAll.UseVisualStyleBackColor = false;
            this.btn_selectAll.Click += new System.EventHandler(this.btn_selectAll_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_reload.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.Location = new System.Drawing.Point(3, 4);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(0);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(306, 59);
            this.btn_reload.TabIndex = 0;
            this.btn_reload.Text = "ReLoad";
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.BackgroundImage = global::ProjectGUI.Properties.Resources.user_information_BG;
            this.User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.User.Controls.Add(this.panel3);
            this.User.Controls.Add(this.panel2);
            this.User.Controls.Add(this.label1);
            this.User.Controls.Add(this.pictureBox1);
            this.User.Location = new System.Drawing.Point(4, 25);
            this.User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(1038, 644);
            this.User.TabIndex = 1;
            this.User.Text = "User";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btn_copyID);
            this.panel3.Controls.Add(this.tb_id);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(205, 356);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 108);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(260, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Copied";
            this.label2.Visible = false;
            // 
            // btn_copyID
            // 
            this.btn_copyID.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_copyID.Location = new System.Drawing.Point(335, 63);
            this.btn_copyID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_copyID.Name = "btn_copyID";
            this.btn_copyID.Size = new System.Drawing.Size(105, 28);
            this.btn_copyID.TabIndex = 2;
            this.btn_copyID.Text = "Copy ID";
            this.btn_copyID.UseVisualStyleBackColor = false;
            this.btn_copyID.Click += new System.EventHandler(this.btn_copyID_Click);
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.DimGray;
            this.tb_id.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_id.Location = new System.Drawing.Point(127, 10);
            this.tb_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(315, 38);
            this.tb_id.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(75, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_username);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(205, 271);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 79);
            this.panel2.TabIndex = 3;
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.DimGray;
            this.tb_username.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_username.Location = new System.Drawing.Point(127, 10);
            this.tb_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(315, 38);
            this.tb_username.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(17, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(360, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "USER INFORMATION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectGUI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(731, 219);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectGUI.Properties.Resources.BackGround_ngang;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1123, 724);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.tabControl1.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.User.ResumeLayout(false);
            this.User.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.TabPage User;
        private System.Windows.Forms.ListView lv_listVideos;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_share;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Button btn_selectAll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_copyID;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
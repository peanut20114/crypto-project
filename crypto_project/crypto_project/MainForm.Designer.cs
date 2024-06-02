namespace crypto_project
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            Main = new TabPage();
            splitContainer1 = new SplitContainer();
            videoList = new ListView();
            selectedVideo = new PictureBox();
            btn_download = new Button();
            btn_upload = new Button();
            btn_share = new Button();
            btn_decrypt = new Button();
            btn_selectAll = new Button();
            btn_reLoad = new Button();
            User = new TabPage();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            textBox3 = new TextBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            username = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            tabControl1.SuspendLayout();
            Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectedVideo).BeginInit();
            User.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Main);
            tabControl1.Controls.Add(User);
            tabControl1.Location = new Point(26, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1159, 668);
            tabControl1.TabIndex = 0;
            // 
            // Main
            // 
            Main.Controls.Add(splitContainer1);
            Main.Location = new Point(4, 29);
            Main.Name = "Main";
            Main.Padding = new Padding(3);
            Main.Size = new Size(1151, 635);
            Main.TabIndex = 0;
            Main.Text = "Main";
            Main.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(videoList);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(selectedVideo);
            splitContainer1.Panel2.Controls.Add(btn_download);
            splitContainer1.Panel2.Controls.Add(btn_upload);
            splitContainer1.Panel2.Controls.Add(btn_share);
            splitContainer1.Panel2.Controls.Add(btn_decrypt);
            splitContainer1.Panel2.Controls.Add(btn_selectAll);
            splitContainer1.Panel2.Controls.Add(btn_reLoad);
            splitContainer1.Panel2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            splitContainer1.Size = new Size(1145, 629);
            splitContainer1.SplitterDistance = 381;
            splitContainer1.TabIndex = 0;
            // 
            // videoList
            // 
            videoList.Location = new Point(3, 3);
            videoList.Name = "videoList";
            videoList.Size = new Size(375, 623);
            videoList.TabIndex = 0;
            videoList.UseCompatibleStateImageBehavior = false;
            // 
            // selectedVideo
            // 
            selectedVideo.BackColor = SystemColors.InactiveCaption;
            selectedVideo.Location = new Point(3, 97);
            selectedVideo.Name = "selectedVideo";
            selectedVideo.Size = new Size(754, 529);
            selectedVideo.TabIndex = 6;
            selectedVideo.TabStop = false;
            // 
            // btn_download
            // 
            btn_download.BackColor = SystemColors.GradientActiveCaption;
            btn_download.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_download.Location = new Point(595, 3);
            btn_download.Margin = new Padding(0);
            btn_download.Name = "btn_download";
            btn_download.Size = new Size(163, 91);
            btn_download.TabIndex = 5;
            btn_download.Text = "Download";
            btn_download.UseVisualStyleBackColor = false;
            // 
            // btn_upload
            // 
            btn_upload.BackColor = SystemColors.GradientActiveCaption;
            btn_upload.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_upload.Location = new Point(432, 3);
            btn_upload.Margin = new Padding(0);
            btn_upload.Name = "btn_upload";
            btn_upload.Size = new Size(163, 91);
            btn_upload.TabIndex = 4;
            btn_upload.Text = "Upload";
            btn_upload.UseVisualStyleBackColor = false;
            // 
            // btn_share
            // 
            btn_share.BackColor = SystemColors.GradientActiveCaption;
            btn_share.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_share.Location = new Point(290, 60);
            btn_share.Margin = new Padding(0);
            btn_share.Name = "btn_share";
            btn_share.Size = new Size(142, 34);
            btn_share.TabIndex = 3;
            btn_share.Text = "Share";
            btn_share.UseVisualStyleBackColor = false;
            // 
            // btn_decrypt
            // 
            btn_decrypt.BackColor = SystemColors.GradientActiveCaption;
            btn_decrypt.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_decrypt.Location = new Point(150, 60);
            btn_decrypt.Margin = new Padding(0);
            btn_decrypt.Name = "btn_decrypt";
            btn_decrypt.Size = new Size(140, 34);
            btn_decrypt.TabIndex = 2;
            btn_decrypt.Text = "Decrypt Video";
            btn_decrypt.UseVisualStyleBackColor = false;
            // 
            // btn_selectAll
            // 
            btn_selectAll.BackColor = SystemColors.GradientActiveCaption;
            btn_selectAll.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_selectAll.Location = new Point(3, 60);
            btn_selectAll.Margin = new Padding(0);
            btn_selectAll.Name = "btn_selectAll";
            btn_selectAll.Size = new Size(147, 34);
            btn_selectAll.TabIndex = 1;
            btn_selectAll.Text = "Select all";
            btn_selectAll.UseVisualStyleBackColor = false;
            // 
            // btn_reLoad
            // 
            btn_reLoad.BackColor = SystemColors.GradientActiveCaption;
            btn_reLoad.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reLoad.Location = new Point(3, 3);
            btn_reLoad.Margin = new Padding(0);
            btn_reLoad.Name = "btn_reLoad";
            btn_reLoad.Size = new Size(429, 57);
            btn_reLoad.TabIndex = 0;
            btn_reLoad.Text = "Reload";
            btn_reLoad.UseVisualStyleBackColor = false;
            // 
            // User
            // 
            User.BackColor = Color.Transparent;
            User.BackgroundImage = Properties.Resources.user_information_BG;
            User.BackgroundImageLayout = ImageLayout.Stretch;
            User.Controls.Add(pictureBox5);
            User.Controls.Add(label6);
            User.Controls.Add(label5);
            User.Controls.Add(button1);
            User.Controls.Add(panel4);
            User.Controls.Add(panel3);
            User.Controls.Add(label4);
            User.Controls.Add(panel2);
            User.Controls.Add(label3);
            User.Controls.Add(label2);
            User.Controls.Add(panel1);
            User.Controls.Add(label1);
            User.Location = new Point(4, 29);
            User.Name = "User";
            User.Padding = new Padding(3);
            User.Size = new Size(1151, 635);
            User.TabIndex = 1;
            User.Text = "User";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(textBox3);
            panel4.Location = new Point(274, 493);
            panel4.Name = "panel4";
            panel4.Size = new Size(345, 55);
            panel4.TabIndex = 7;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.key__icon;
            pictureBox4.Location = new Point(10, 11);
            pictureBox4.Margin = new Padding(5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DimGray;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(74, 15);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(271, 24);
            textBox3.TabIndex = 1;
            textBox3.Text = "123456";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(textBox2);
            panel3.Location = new Point(274, 432);
            panel3.Name = "panel3";
            panel3.Size = new Size(345, 55);
            panel3.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.key__icon;
            pictureBox2.Location = new Point(10, 11);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.DimGray;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(74, 15);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 24);
            textBox2.TabIndex = 1;
            textBox2.Text = "123456";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(271, 384);
            label4.Name = "label4";
            label4.Size = new Size(155, 28);
            label4.TabIndex = 5;
            label4.Text = "RSA Public Key";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(271, 311);
            panel2.Name = "panel2";
            panel2.Size = new Size(345, 55);
            panel2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.id_icon;
            pictureBox3.Location = new Point(13, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DimGray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(74, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 24);
            textBox1.TabIndex = 1;
            textBox1.Text = "123456";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(271, 280);
            label3.Name = "label3";
            label3.Size = new Size(33, 28);
            label3.TabIndex = 3;
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(271, 176);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(username);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(271, 207);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 55);
            panel1.TabIndex = 1;
            // 
            // username
            // 
            username.BackColor = Color.DimGray;
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(74, 15);
            username.Name = "username";
            username.Size = new Size(271, 24);
            username.TabIndex = 1;
            username.Text = "tk11";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_user_;
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 49);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(393, 59);
            label1.Name = "label1";
            label1.Size = new Size(411, 54);
            label1.TabIndex = 0;
            label1.Text = "USER INFORMATION";
            // 
            // button1
            // 
            button1.Location = new Point(525, 276);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "copy ID";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(212, 447);
            label5.Name = "label5";
            label5.Size = new Size(33, 28);
            label5.TabIndex = 9;
            label5.Text = "N:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(212, 508);
            label6.Name = "label6";
            label6.Size = new Size(28, 28);
            label6.TabIndex = 10;
            label6.Text = "E:";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Logo1;
            pictureBox5.Location = new Point(656, 184);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(360, 364);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackGround_ngang;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1197, 692);
            Controls.Add(tabControl1);
            DoubleBuffered = true;
            Name = "MainForm";
            Text = "MainForm";
            tabControl1.ResumeLayout(false);
            Main.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)selectedVideo).EndInit();
            User.ResumeLayout(false);
            User.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Main;
        private TabPage User;
        private SplitContainer splitContainer1;
        private BindingSource bindingSource1;
        private ListView videoList;
        private Button btn_selectAll;
        private Button btn_reLoad;
        private Button btn_download;
        private Button btn_upload;
        private Button btn_share;
        private Button btn_decrypt;
        private PictureBox selectedVideo;
        private Label label1;
        private Panel panel1;
        private TextBox username;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private PictureBox pictureBox4;
        private TextBox textBox3;
        private Panel panel3;
        private PictureBox pictureBox2;
        private TextBox textBox2;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label6;
        private Label label5;
        private Button button1;
        private PictureBox pictureBox5;
    }
}
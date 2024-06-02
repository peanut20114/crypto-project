namespace crypto_project
{
    partial class Sign_In
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PictureBox pictureBox2;
            panel1 = new Panel();
            username = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            password = new TextBox();
            linkSignUp = new LinkLabel();
            btn_logIn = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.icon_pass;
            pictureBox2.Location = new Point(1, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 55);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(username);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(43, 301);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 55);
            panel1.TabIndex = 0;
            // 
            // username
            // 
            username.BackColor = Color.DimGray;
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(57, 15);
            username.Name = "username";
            username.Size = new Size(271, 27);
            username.TabIndex = 1;
            username.Text = "Type your username";
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
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(password);
            panel2.Location = new Point(43, 375);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 61);
            panel2.TabIndex = 1;
            // 
            // password
            // 
            password.BackColor = Color.DimGray;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(55, 14);
            password.Name = "password";
            password.Size = new Size(271, 27);
            password.TabIndex = 1;
            password.Text = "Type your password";
            // 
            // linkSignUp
            // 
            linkSignUp.AutoSize = true;
            linkSignUp.BackColor = Color.Transparent;
            linkSignUp.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkSignUp.ForeColor = Color.DarkGray;
            linkSignUp.LinkColor = Color.DodgerBlue;
            linkSignUp.Location = new Point(44, 442);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.Size = new Size(142, 22);
            linkSignUp.TabIndex = 2;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Sign up account?";
            linkSignUp.LinkClicked += linkSignUp_LinkClicked;
            // 
            // btn_logIn
            // 
            btn_logIn.BackColor = SystemColors.ButtonShadow;
            btn_logIn.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logIn.Location = new Point(255, 442);
            btn_logIn.Name = "btn_logIn";
            btn_logIn.Size = new Size(131, 45);
            btn_logIn.TabIndex = 3;
            btn_logIn.Text = "LOGIN";
            btn_logIn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(143, 197);
            label1.Name = "label1";
            label1.Size = new Size(156, 45);
            label1.TabIndex = 4;
            label1.Text = "SIGN IN";
            // 
            // Sign_In
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackGround;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(430, 704);
            Controls.Add(label1);
            Controls.Add(btn_logIn);
            Controls.Add(linkSignUp);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Sign_In";
            Text = "Sign In";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox username;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox password;
        private LinkLabel linkSignUp;
        private Button btn_logIn;
        private Label label1;
    }
}

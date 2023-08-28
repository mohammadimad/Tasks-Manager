
namespace WindowsFormsApp17
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInvalidPassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtSignInPassword = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInvalidAdmin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TxtSignInAdmin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnUploadPhoto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInvalidPasswordSignUp = new System.Windows.Forms.Label();
            this.Pb3 = new System.Windows.Forms.PictureBox();
            this.TxtPasswordSignUp = new System.Windows.Forms.TextBox();
            this.PanelAdminSignIn = new System.Windows.Forms.Panel();
            this.lblInvalidAdminSignUp = new System.Windows.Forms.Label();
            this.Pb2 = new System.Windows.Forms.PictureBox();
            this.TxtAdminSignUp = new System.Windows.Forms.TextBox();
            this.PbAvatar = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb3)).BeginInit();
            this.PanelAdminSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(412, 489);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnSignIn);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(404, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sign In";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.BtnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.ForeColor = System.Drawing.Color.Black;
            this.BtnSignIn.Location = new System.Drawing.Point(87, 392);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(237, 56);
            this.BtnSignIn.TabIndex = 0;
            this.BtnSignIn.Text = "Sign In";
            this.BtnSignIn.UseVisualStyleBackColor = false;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblInvalidPassword);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.TxtSignInPassword);
            this.panel2.Location = new System.Drawing.Point(84, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 65);
            this.panel2.TabIndex = 33;
            // 
            // lblInvalidPassword
            // 
            this.lblInvalidPassword.AutoSize = true;
            this.lblInvalidPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidPassword.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidPassword.Location = new System.Drawing.Point(8, 41);
            this.lblInvalidPassword.Name = "lblInvalidPassword";
            this.lblInvalidPassword.Size = new System.Drawing.Size(116, 16);
            this.lblInvalidPassword.TabIndex = 30;
            this.lblInvalidPassword.Text = "Invalid Password !";
            this.lblInvalidPassword.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // TxtSignInPassword
            // 
            this.TxtSignInPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(196)))), ((int)(((byte)(210)))));
            this.TxtSignInPassword.Location = new System.Drawing.Point(30, 18);
            this.TxtSignInPassword.Name = "TxtSignInPassword";
            this.TxtSignInPassword.PasswordChar = '*';
            this.TxtSignInPassword.Size = new System.Drawing.Size(212, 20);
            this.TxtSignInPassword.TabIndex = 0;
            this.TxtSignInPassword.Text = "admin1";
            this.TxtSignInPassword.TextChanged += new System.EventHandler(this.TxtSignInPassword_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblInvalidAdmin);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.TxtSignInAdmin);
            this.panel3.Location = new System.Drawing.Point(84, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 65);
            this.panel3.TabIndex = 32;
            // 
            // lblInvalidAdmin
            // 
            this.lblInvalidAdmin.AutoSize = true;
            this.lblInvalidAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidAdmin.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidAdmin.Location = new System.Drawing.Point(8, 43);
            this.lblInvalidAdmin.Name = "lblInvalidAdmin";
            this.lblInvalidAdmin.Size = new System.Drawing.Size(94, 16);
            this.lblInvalidAdmin.TabIndex = 29;
            this.lblInvalidAdmin.Text = "Invalid Admin !";
            this.lblInvalidAdmin.Visible = false;
            //this.lblInvalidAdmin.Click += new System.EventHandler(this.lblInvalidAdmin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // TxtSignInAdmin
            // 
            this.TxtSignInAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(196)))), ((int)(((byte)(210)))));
            this.TxtSignInAdmin.Location = new System.Drawing.Point(30, 16);
            this.TxtSignInAdmin.Name = "TxtSignInAdmin";
            this.TxtSignInAdmin.Size = new System.Drawing.Size(212, 20);
            this.TxtSignInAdmin.TabIndex = 0;
            this.TxtSignInAdmin.Text = "admin";
            this.TxtSignInAdmin.TextChanged += new System.EventHandler(this.TxtSignInAdmin_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Task Managment System";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(95, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(198, 114);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnUploadPhoto);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.PanelAdminSignIn);
            this.tabPage2.Controls.Add(this.PbAvatar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(404, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sign Up";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnUploadPhoto
            // 
            this.BtnUploadPhoto.BackColor = System.Drawing.Color.White;
            this.BtnUploadPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnUploadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUploadPhoto.Image = global::WindowsFormsApp17.Properties.Resources.icons8_upload_24;
            this.BtnUploadPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUploadPhoto.Location = new System.Drawing.Point(85, 158);
            this.BtnUploadPhoto.Name = "BtnUploadPhoto";
            this.BtnUploadPhoto.Size = new System.Drawing.Size(174, 58);
            this.BtnUploadPhoto.TabIndex = 30;
            this.BtnUploadPhoto.Text = " Upload Photo";
            this.BtnUploadPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUploadPhoto.UseVisualStyleBackColor = false;
            this.BtnUploadPhoto.Click += new System.EventHandler(this.BtnUploadPhoto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(65, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 56);
            this.button1.TabIndex = 29;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblInvalidPasswordSignUp);
            this.panel1.Controls.Add(this.Pb3);
            this.panel1.Controls.Add(this.TxtPasswordSignUp);
            this.panel1.Location = new System.Drawing.Point(62, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 65);
            this.panel1.TabIndex = 28;
            // 
            // lblInvalidPasswordSignUp
            // 
            this.lblInvalidPasswordSignUp.AutoSize = true;
            this.lblInvalidPasswordSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidPasswordSignUp.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidPasswordSignUp.Location = new System.Drawing.Point(8, 41);
            this.lblInvalidPasswordSignUp.Name = "lblInvalidPasswordSignUp";
            this.lblInvalidPasswordSignUp.Size = new System.Drawing.Size(212, 16);
            this.lblInvalidPasswordSignUp.TabIndex = 30;
            this.lblInvalidPasswordSignUp.Text = "Password Must Be Bigger Than 6 !";
            // 
            // Pb3
            // 
            this.Pb3.BackColor = System.Drawing.Color.White;
            this.Pb3.Image = ((System.Drawing.Image)(resources.GetObject("Pb3.Image")));
            this.Pb3.Location = new System.Drawing.Point(3, 14);
            this.Pb3.Name = "Pb3";
            this.Pb3.Size = new System.Drawing.Size(24, 24);
            this.Pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb3.TabIndex = 29;
            this.Pb3.TabStop = false;
            // 
            // TxtPasswordSignUp
            // 
            this.TxtPasswordSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(196)))), ((int)(((byte)(210)))));
            this.TxtPasswordSignUp.Location = new System.Drawing.Point(30, 18);
            this.TxtPasswordSignUp.Name = "TxtPasswordSignUp";
            this.TxtPasswordSignUp.PasswordChar = '*';
            this.TxtPasswordSignUp.Size = new System.Drawing.Size(212, 20);
            this.TxtPasswordSignUp.TabIndex = 0;
            this.TxtPasswordSignUp.TextChanged += new System.EventHandler(this.TxtPasswordSignUp_TextChanged);
            // 
            // PanelAdminSignIn
            // 
            this.PanelAdminSignIn.Controls.Add(this.lblInvalidAdminSignUp);
            this.PanelAdminSignIn.Controls.Add(this.Pb2);
            this.PanelAdminSignIn.Controls.Add(this.TxtAdminSignUp);
            this.PanelAdminSignIn.Location = new System.Drawing.Point(62, 239);
            this.PanelAdminSignIn.Name = "PanelAdminSignIn";
            this.PanelAdminSignIn.Size = new System.Drawing.Size(245, 65);
            this.PanelAdminSignIn.TabIndex = 27;
            // 
            // lblInvalidAdminSignUp
            // 
            this.lblInvalidAdminSignUp.AutoSize = true;
            this.lblInvalidAdminSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalidAdminSignUp.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidAdminSignUp.Location = new System.Drawing.Point(8, 43);
            this.lblInvalidAdminSignUp.Name = "lblInvalidAdminSignUp";
            this.lblInvalidAdminSignUp.Size = new System.Drawing.Size(165, 16);
            this.lblInvalidAdminSignUp.TabIndex = 29;
            this.lblInvalidAdminSignUp.Text = "Admin Must not Be Empty !";
            // 
            // Pb2
            // 
            this.Pb2.BackColor = System.Drawing.Color.White;
            this.Pb2.Image = ((System.Drawing.Image)(resources.GetObject("Pb2.Image")));
            this.Pb2.Location = new System.Drawing.Point(3, 16);
            this.Pb2.Name = "Pb2";
            this.Pb2.Size = new System.Drawing.Size(24, 24);
            this.Pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pb2.TabIndex = 28;
            this.Pb2.TabStop = false;
            // 
            // TxtAdminSignUp
            // 
            this.TxtAdminSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(196)))), ((int)(((byte)(210)))));
            this.TxtAdminSignUp.Location = new System.Drawing.Point(30, 16);
            this.TxtAdminSignUp.Name = "TxtAdminSignUp";
            this.TxtAdminSignUp.Size = new System.Drawing.Size(212, 20);
            this.TxtAdminSignUp.TabIndex = 0;
            this.TxtAdminSignUp.TextChanged += new System.EventHandler(this.TxtAdminSignUp_TextChanged);
            // 
            // PbAvatar
            // 
            this.PbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("PbAvatar.Image")));
            this.PbAvatar.Location = new System.Drawing.Point(73, 24);
            this.PbAvatar.Name = "PbAvatar";
            this.PbAvatar.Size = new System.Drawing.Size(198, 114);
            this.PbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbAvatar.TabIndex = 25;
            this.PbAvatar.TabStop = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 491);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.Text = "Task";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb3)).EndInit();
            this.PanelAdminSignIn.ResumeLayout(false);
            this.PanelAdminSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblInvalidPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtSignInPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblInvalidAdmin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtSignInAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnUploadPhoto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInvalidPasswordSignUp;
        private System.Windows.Forms.PictureBox Pb3;
        private System.Windows.Forms.TextBox TxtPasswordSignUp;
        private System.Windows.Forms.Panel PanelAdminSignIn;
        private System.Windows.Forms.Label lblInvalidAdminSignUp;
        private System.Windows.Forms.PictureBox Pb2;
        private System.Windows.Forms.TextBox TxtAdminSignUp;
        private System.Windows.Forms.PictureBox PbAvatar;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        struct stAccountInfo
        {
            public string Admin;
            public string Password;
            public string AvatarFilePath;
            public string DataNow;
        }
        stAccountInfo AccountInfo;
       
        void UploadPhoto()
        {
            OpenFileDialog OpenFileDi = new OpenFileDialog();
            OpenFileDi.Title = "Avatar Select";
            OpenFileDi.Filter = "(All Images Files)|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG";
            OpenFileDi.FilterIndex = 3;

            if (OpenFileDi.ShowDialog() == DialogResult.OK)
            {

                AccountInfo.AvatarFilePath = OpenFileDi.FileName;
                PbAvatar.Image = Image.FromFile(AccountInfo.AvatarFilePath);
            }
        }
        void LoadDefaultAccountInfo()
        {
            AccountInfo.Admin = "admin";
            AccountInfo.Password = "admin1";
            AccountInfo.AvatarFilePath = null;
        }
        void AssignAccountInfo()
        {
            AccountInfo.Admin = TxtAdminSignUp.Text;
            AccountInfo.Password = TxtPasswordSignUp.Text;
        }
        bool Signin()
        {
            bool IsAdminRight = CheckSignInAdmin();
            bool IsPasswordRight = CheckSignInPassword();
            if (IsAdminRight)
            {
                lblInvalidAdmin.Visible = true;
                TxtSignInAdmin.Text = string.Empty;
            }
            if (IsPasswordRight)
            {
                lblInvalidPassword.Visible = true;
                TxtSignInPassword.Text = string.Empty;
            }
            if (IsPasswordRight && IsAdminRight)
            {
                MessageBox.Show("Sign In Success", "Sign In Up",MessageBoxButtons.OK
                    ,MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
        
        void Signup()
        {
            bool IsAdminRight = CheckSignUpAdmin();
            bool IsPasswordRight = CheckSignUpPassword();

            if (!IsAdminRight)
            {
                lblInvalidAdminSignUp.Visible = true;
                TxtAdminSignUp.Text = string.Empty;
            }

            if (!IsPasswordRight)
            {
                lblInvalidPasswordSignUp.Visible = true;
                TxtPasswordSignUp.Text = string.Empty;
            }

            if (IsAdminRight && IsPasswordRight)
            {
                MessageBox.Show("Sign Up Success", "Sign Up", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                AssignAccountInfo();
                
            }

        }


        bool CheckSignInAdmin()
        {
            return TxtSignInAdmin.Text == AccountInfo.Admin;
        }
        bool CheckSignInPassword()
        {
            return TxtSignInPassword.Text == AccountInfo.Password;
        }
        bool CheckSignUpAdmin()
        {
            return !string.IsNullOrEmpty(TxtAdminSignUp.Text);
        }
        bool CheckSignUpPassword()
        {
            return TxtPasswordSignUp.Text.Length >= 6;
        }
        private void TxtSignInAdmin_TextChanged(object sender, EventArgs e)
        {
            lblInvalidAdmin.Visible = false;
        }
        private void BtnUploadPhoto_Click(object sender, EventArgs e)
        {
            UploadPhoto();
        }

        private void TxtAdminSignUp_TextChanged(object sender, EventArgs e)
        {
            lblInvalidAdminSignUp.Visible = false;
        }

        private void TxtSignInPassword_TextChanged(object sender, EventArgs e)
        {
            lblInvalidPassword.Visible = false;
        }

        private void TxtPasswordSignUp_TextChanged(object sender, EventArgs e)
        {
            lblInvalidPasswordSignUp.Visible = false;
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            LoadDefaultAccountInfo();
            TxtSignInAdmin.Text = "admin";
            TxtSignInPassword.Text = "admin1";
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            AccountInfo.DataNow = DateTime.Today.ToString("d");
            if (Signin() == true)
            {
                Home_Form AppForm = new Home_Form(AccountInfo.Admin,
                    AccountInfo.AvatarFilePath,AccountInfo.DataNow);
                
                this.Hide();
                AppForm.ShowDialog();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signup();
            TxtSignInAdmin.Text = string.Empty;
            TxtSignInPassword.Text = string.Empty;
        }

        
    }
}

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;

namespace Monisoft_04._070821
{
    public partial class Intro : Form
    {
        Thread th;
        public Intro()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void opennewform(object obj)
        {
            Application.Run(new Dashboard());
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelIDShow_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "nbhung")
            {
                if (txtPassword.Text != "password")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUser.Text, txtPassword.Text);
                    if (validLogin == true)
                    {
                        Dashboard mainMenu = new Dashboard();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }    
                    else
                    {
                        msgError("Tên người dùng hoặc mật khẩu đã nhập không\nchính xác. Vui lòng thử lại.");
                        txtPassword.Clear();
                        txtUser.Focus();
                    }

                }
                else msgError("Vui lòng nhập mật khẩu.");
            }
            else msgError("Vui lòng nhập tên đăng nhập. ");
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = " " + msg;
            lblErrorMessage.Visible = true;
            lblErrorMessage2.Visible = true;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            
        }
        

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "nbhung")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "nbhung";
                txtUser.ForeColor = Color.DarkGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text=="")
            {
                txtPassword.Text = "password";
                txtPassword.ForeColor = Color.DarkGray;
                txtPassword.UseSystemPasswordChar = false;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPassword.Clear();
            txtUser.Clear();
            lblErrorMessage.Visible = false;
            this.Show();
            txtUser.Focus();
        }
    }
}

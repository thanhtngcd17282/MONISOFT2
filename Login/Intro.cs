using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Monisoft_04._070821
{
    public partial class Intro : Form
    {
        Thread th;
        public Intro()
        {
            InitializeComponent();
        }


        private void opennewform(object obj)
        {
            Application.Run(new Main());
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
    }
}

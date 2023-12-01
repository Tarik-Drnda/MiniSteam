using MiniSteam.Data.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniSteam.Data;
using MiniSteam.UX.Tools;

namespace MiniSteam.UX
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private User loggedUser { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            if (!username.isValid() && !password.isValid())
            {
                loggedUser = ValidatorLogin.FindUser(username, password);
                if (loggedUser != null)
                {
                    var frmGlavna = new frmMain();
                    
                    frmGlavna.ShowDialog();
                    
                }
                else
                {

                    MessageBox.Show("Korisnicko ime ili sifra ne postoji u nasoj Bazi!","Greška prilikom prijave",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                ErrorHandler(txtUsername, errLoginError, "Please enter username!");
                ErrorHandler(txtPassword, errLoginError, "Please enter password!");
            }
        }
        private void ErrorHandler(Control kontrola, ErrorProvider err, string Message)
        {
            if (kontrola is TextBox)
            {
                (kontrola as TextBox).BackColor = Color.Red;
                err.SetError(kontrola, Message);
            }

        }
    }
}

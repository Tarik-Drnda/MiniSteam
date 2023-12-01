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

namespace MiniSteam.UX
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username=txtUsername.Text;
            var password=txtPassword.Text;
            if(!username.isValid() && !password.isValid()) 
            {

            }
            else
            {
                ErrorHandler(txtUsername, errLoginError, "Please enter username!");
                ErrorHandler(txtPassword, errLoginError, "Please enter password!");
            }
        }
        private void ErrorHandler(Control kontrola,ErrorProvider err, string Message)
        {
            if(kontrola is TextBox)
            {
                (kontrola as TextBox).BackColor = Color.Red;
                err.SetError(kontrola, Message);
            }
            
        }
    }
}

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
using MiniSteam.UX.Registration;

namespace MiniSteam.UX
{
    public partial class frmLogin : Form
    {
        DBMiniSteamContext baza = new DBMiniSteamContext();
        public frmLogin()
        {
            InitializeComponent();
        }

        private User loggedUser { get; set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidanLogin())
            {
                //User? korisnik = null;

                var korisnici = baza.Users.ToList().Where(u => u.UserName==txtUsername.Text && u.Password==txtPassword.Text);

                //foreach (var user in korisnici)
                //{
                //    if (user.Ime == txtUsername.Text && user.Password == txtPassword.Text)
                //    {
                //        korisnik = user;
                //    }
                //}
                if (korisnici.Count() > 0)
                {
                    loggedUser = korisnici.First() as User;
                    var fMain = new frmMain();
                    fMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Korisnički podaci nisu tačni!", Kljucevi.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidanLogin()
        {
            return Validator.ValidanUnos(txtUsername, errLoginError, Kljucevi.MandatoryValue)
                && Validator.ValidanUnos(txtPassword, errLoginError, Kljucevi.MandatoryValue);
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            var fReg = new frmRegistration();
            fReg.ShowDialog();
        }

        private void btnNewUser_MouseHover(object sender, EventArgs e)
        {
        }
    }
}

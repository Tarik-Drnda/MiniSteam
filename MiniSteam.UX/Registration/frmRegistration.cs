using MiniSteam.Data;
using MiniSteam.Data.Helpers;
using MiniSteam.UX.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSteam.UX.Registration
{
    public partial class frmRegistration : Form
    {
        DBMiniSteamContext baza = new DBMiniSteamContext();
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var user = new User()
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Prezime = txtPrezime.Text,
                Ime = txtIme.Text,
                UserName= txtUserName.Text,
                pPicture=pbRegistrationPhoto.Image.ToByteArray()
            };
            
            baza.Users.Add(user);
            baza.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            ofdPicture.ShowDialog();
            pbRegistrationPhoto.Image = Image.FromFile(ofdPicture.FileName);
        }
    }
}

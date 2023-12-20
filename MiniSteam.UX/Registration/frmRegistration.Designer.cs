namespace MiniSteam.UX.Registration
{
    partial class frmRegistration
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
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnDodaj = new Button();
            lblRegistrationTag = new Label();
            pbRegistrationPhoto = new PictureBox();
            btnSelectPhoto = new Button();
            errRegistration = new ErrorProvider(components);
            ofdPicture = new OpenFileDialog();
            lblName = new Label();
            lblPrezime = new Label();
            label1 = new Label();
            btnGeneratePsw = new Button();
            lblEmail = new Label();
            lblUserName = new Label();
            txtUserName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbRegistrationPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errRegistration).BeginInit();
            SuspendLayout();
            // 
            // txtIme
            // 
            txtIme.Location = new Point(211, 100);
            txtIme.Margin = new Padding(3, 4, 3, 4);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(114, 27);
            txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(211, 209);
            txtPrezime.Margin = new Padding(3, 4, 3, 4);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(114, 27);
            txtPrezime.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(389, 209);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(145, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(389, 99);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(145, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(211, 275);
            btnDodaj.Margin = new Padding(3, 4, 3, 4);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(291, 31);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Finish";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // lblRegistrationTag
            // 
            lblRegistrationTag.AutoSize = true;
            lblRegistrationTag.Font = new Font("Sylfaen", 18F, FontStyle.Bold | FontStyle.Italic);
            lblRegistrationTag.ForeColor = SystemColors.ButtonHighlight;
            lblRegistrationTag.Location = new Point(99, 12);
            lblRegistrationTag.Name = "lblRegistrationTag";
            lblRegistrationTag.Size = new Size(440, 39);
            lblRegistrationTag.TabIndex = 6;
            lblRegistrationTag.Text = "MiniSteam Registration system";
            // 
            // pbRegistrationPhoto
            // 
            pbRegistrationPhoto.BackgroundImageLayout = ImageLayout.Stretch;
            pbRegistrationPhoto.Location = new Point(25, 75);
            pbRegistrationPhoto.Margin = new Padding(3, 4, 3, 4);
            pbRegistrationPhoto.Name = "pbRegistrationPhoto";
            pbRegistrationPhoto.Size = new Size(160, 192);
            pbRegistrationPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRegistrationPhoto.TabIndex = 7;
            pbRegistrationPhoto.TabStop = false;
            // 
            // btnSelectPhoto
            // 
            btnSelectPhoto.Location = new Point(25, 275);
            btnSelectPhoto.Margin = new Padding(3, 4, 3, 4);
            btnSelectPhoto.Name = "btnSelectPhoto";
            btnSelectPhoto.Size = new Size(160, 31);
            btnSelectPhoto.TabIndex = 8;
            btnSelectPhoto.Text = "Odabir";
            btnSelectPhoto.UseVisualStyleBackColor = true;
            btnSelectPhoto.Click += btnSelectPhoto_Click;
            // 
            // errRegistration
            // 
            errRegistration.ContainerControl = this;
            // 
            // ofdPicture
            // 
            ofdPicture.FileName = "openFileDialog1";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblName.Location = new Point(214, 76);
            lblName.Name = "lblName";
            lblName.Size = new Size(40, 20);
            lblName.TabIndex = 9;
            lblName.Text = "Ime:";
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrezime.Location = new Point(211, 185);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(69, 20);
            lblPrezime.TabIndex = 10;
            lblPrezime.Text = "Prezime:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(389, 75);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 11;
            label1.Text = "Password:";
            // 
            // btnGeneratePsw
            // 
            btnGeneratePsw.Location = new Point(389, 144);
            btnGeneratePsw.Margin = new Padding(3, 4, 3, 4);
            btnGeneratePsw.Name = "btnGeneratePsw";
            btnGeneratePsw.Size = new Size(145, 31);
            btnGeneratePsw.TabIndex = 12;
            btnGeneratePsw.Text = "Generate password";
            btnGeneratePsw.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(389, 185);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserName.Location = new Point(211, 131);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(87, 20);
            lblUserName.TabIndex = 14;
            lblUserName.Text = "UserName:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(211, 154);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(114, 27);
            txtUserName.TabIndex = 15;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(579, 321);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(lblEmail);
            Controls.Add(btnGeneratePsw);
            Controls.Add(label1);
            Controls.Add(lblPrezime);
            Controls.Add(lblName);
            Controls.Add(btnSelectPhoto);
            Controls.Add(pbRegistrationPhoto);
            Controls.Add(lblRegistrationTag);
            Controls.Add(btnDodaj);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbRegistrationPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)errRegistration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnDodaj;
        private Label lblRegistrationTag;
        private PictureBox pbRegistrationPhoto;
        private Button btnSelectPhoto;
        private ErrorProvider errRegistration;
        private Label label1;
        private Label lblPrezime;
        private Label lblName;
        private OpenFileDialog ofdPicture;
        private Label lblEmail;
        private Button btnGeneratePsw;
        private TextBox txtUserName;
        private Label lblUserName;
    }
}
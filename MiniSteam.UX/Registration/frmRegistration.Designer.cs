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
            ((System.ComponentModel.ISupportInitialize)pbRegistrationPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errRegistration).BeginInit();
            SuspendLayout();
            // 
            // txtIme
            // 
            txtIme.Location = new Point(185, 79);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(100, 23);
            txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(185, 157);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(100, 23);
            txtPrezime.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(340, 157);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(127, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(340, 79);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(127, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(185, 206);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(255, 23);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Finish";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // lblRegistrationTag
            // 
            lblRegistrationTag.AutoSize = true;
            lblRegistrationTag.Font = new Font("Sylfaen", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblRegistrationTag.ForeColor = SystemColors.ButtonHighlight;
            lblRegistrationTag.Location = new Point(87, 9);
            lblRegistrationTag.Name = "lblRegistrationTag";
            lblRegistrationTag.Size = new Size(353, 31);
            lblRegistrationTag.TabIndex = 6;
            lblRegistrationTag.Text = "MiniSteam Registration system";
            // 
            // pbRegistrationPhoto
            // 
            pbRegistrationPhoto.Location = new Point(40, 56);
            pbRegistrationPhoto.Name = "pbRegistrationPhoto";
            pbRegistrationPhoto.Size = new Size(122, 144);
            pbRegistrationPhoto.TabIndex = 7;
            pbRegistrationPhoto.TabStop = false;
            // 
            // btnSelectPhoto
            // 
            btnSelectPhoto.Location = new Point(40, 206);
            btnSelectPhoto.Name = "btnSelectPhoto";
            btnSelectPhoto.Size = new Size(122, 23);
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
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(187, 57);
            lblName.Name = "lblName";
            lblName.Size = new Size(32, 15);
            lblName.TabIndex = 9;
            lblName.Text = "Ime:";
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrezime.Location = new Point(185, 139);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(56, 15);
            lblPrezime.TabIndex = 10;
            lblPrezime.Text = "Prezime:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(340, 61);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 11;
            label1.Text = "Password:";
            // 
            // btnGeneratePsw
            // 
            btnGeneratePsw.Location = new Point(340, 108);
            btnGeneratePsw.Name = "btnGeneratePsw";
            btnGeneratePsw.Size = new Size(127, 23);
            btnGeneratePsw.TabIndex = 12;
            btnGeneratePsw.Text = "Generate password";
            btnGeneratePsw.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(340, 139);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email:";
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(507, 241);
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
            Name = "frmRegistration";
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
    }
}
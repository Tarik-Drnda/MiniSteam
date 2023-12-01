namespace MiniSteam.UX
{
    partial class frmLogin
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
            pcbLogin = new PictureBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            errLoginError = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pcbLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errLoginError).BeginInit();
            SuspendLayout();
            // 
            // pcbLogin
            // 
            pcbLogin.AccessibleRole = AccessibleRole.MenuItem;
            pcbLogin.BackgroundImageLayout = ImageLayout.None;
            pcbLogin.BorderStyle = BorderStyle.Fixed3D;
            pcbLogin.Image = Properties.Resources.w_login;
            pcbLogin.Location = new Point(2, -1);
            pcbLogin.Name = "pcbLogin";
            pcbLogin.Size = new Size(796, 453);
            pcbLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogin.TabIndex = 0;
            pcbLogin.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.MediumTurquoise;
            txtPassword.Location = new Point(304, 230);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(202, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.MediumTurquoise;
            txtUsername.Location = new Point(304, 157);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(202, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.White;
            lblUsername.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(334, 125);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(130, 29);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.White;
            lblPassword.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(334, 198);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(140, 29);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Red;
            btnLogin.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(304, 263);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(202, 41);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // errLoginError
            // 
            errLoginError.ContainerControl = this;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(pcbLogin);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)pcbLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)errLoginError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;
        private ErrorProvider errLoginError;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            errLoginError = new ErrorProvider(components);
            pcbLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errLoginError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogin).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.MediumTurquoise;
            txtPassword.Location = new Point(412, 170);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(177, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.MediumTurquoise;
            txtUsername.Location = new Point(412, 110);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(177, 23);
            txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Tw Cen MT", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.Lime;
            lblUsername.Location = new Point(412, 74);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(125, 34);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Tw Cen MT", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.Lime;
            lblPassword.Location = new Point(412, 134);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(123, 34);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Red;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(412, 197);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(177, 35);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // errLoginError
            // 
            errLoginError.ContainerControl = this;
            // 
            // pcbLogin
            // 
            pcbLogin.BackColor = Color.Transparent;
            pcbLogin.BackgroundImageLayout = ImageLayout.Stretch;
            pcbLogin.Image = Properties.Resources.shigure_ui_dance;
            pcbLogin.Location = new Point(135, 74);
            pcbLogin.Name = "pcbLogin";
            pcbLogin.Size = new Size(191, 158);
            pcbLogin.TabIndex = 6;
            pcbLogin.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(pcbLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnLogin);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)errLoginError).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;
        private ErrorProvider errLoginError;
        private PictureBox pcbLogin;
    }
}
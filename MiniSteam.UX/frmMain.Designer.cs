namespace MiniSteam.UX
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvGamesWindow = new DataGridView();
            GameName = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Rating = new DataGridViewTextBoxColumn();
            btnLogOut = new Button();
            pcbProfilePicture = new PictureBox();
            txtName = new TextBox();
            lblWelcome = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGamesWindow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // dgvGamesWindow
            // 
            dgvGamesWindow.AllowUserToAddRows = false;
            dgvGamesWindow.AllowUserToDeleteRows = false;
            dgvGamesWindow.BackgroundColor = SystemColors.InactiveBorder;
            dgvGamesWindow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGamesWindow.Columns.AddRange(new DataGridViewColumn[] { GameName, Author, Description, Rating });
            dgvGamesWindow.GridColor = Color.FromArgb(0, 192, 0);
            dgvGamesWindow.Location = new Point(12, 78);
            dgvGamesWindow.MultiSelect = false;
            dgvGamesWindow.Name = "dgvGamesWindow";
            dgvGamesWindow.ReadOnly = true;
            dgvGamesWindow.RowHeadersWidth = 51;
            dgvGamesWindow.RowTemplate.Height = 29;
            dgvGamesWindow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGamesWindow.Size = new Size(957, 404);
            dgvGamesWindow.TabIndex = 0;
            // 
            // GameName
            // 
            GameName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GameName.DataPropertyName = "GameName";
            GameName.HeaderText = "GameName";
            GameName.MinimumWidth = 6;
            GameName.Name = "GameName";
            GameName.ReadOnly = true;
            // 
            // Author
            // 
            Author.DataPropertyName = "Author";
            Author.HeaderText = "Author";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.ReadOnly = true;
            Author.Width = 125;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // Rating
            // 
            Rating.DataPropertyName = "Rating";
            Rating.HeaderText = "Rating";
            Rating.MinimumWidth = 6;
            Rating.Name = "Rating";
            Rating.ReadOnly = true;
            Rating.Width = 125;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(875, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 49);
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // pcbProfilePicture
            // 
            pcbProfilePicture.Location = new Point(12, 10);
            pcbProfilePicture.Name = "pcbProfilePicture";
            pcbProfilePicture.Size = new Size(95, 62);
            pcbProfilePicture.TabIndex = 2;
            pcbProfilePicture.TabStop = false;
            // 
            // txtName
            // 
            txtName.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(323, 10);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 60);
            txtName.TabIndex = 3;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.Location = new Point(142, 26);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(158, 35);
            lblWelcome.TabIndex = 4;
            lblWelcome.Text = "Welcome ";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 494);
            Controls.Add(lblWelcome);
            Controls.Add(txtName);
            Controls.Add(pcbProfilePicture);
            Controls.Add(btnLogOut);
            Controls.Add(dgvGamesWindow);
            Name = "frmMain";
            Text = "MiniSteam";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGamesWindow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbProfilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGamesWindow;
        private DataGridViewTextBoxColumn GameName;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Rating;
        private Button btnLogOut;
        private PictureBox pcbProfilePicture;
        private TextBox txtName;
        private Label lblWelcome;
    }
}
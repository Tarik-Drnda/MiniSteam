using System.Drawing;
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
            lblCaption = new Label();
            cmbRatingGames = new ComboBox();
            lblRating = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGamesWindow).BeginInit();
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
            dgvGamesWindow.Location = new Point(11, 77);
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
            // lblCaption
            // 
            lblCaption.AutoSize = true;
            lblCaption.BackColor = Color.Transparent;
            lblCaption.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaption.ForeColor = SystemColors.ControlLightLight;
            lblCaption.Location = new Point(14, 26);
            lblCaption.Name = "lblCaption";
            lblCaption.Size = new Size(148, 38);
            lblCaption.TabIndex = 2;
            lblCaption.Text = "MiniSteam";
            // 
            // cmbRatingGames
            // 
            cmbRatingGames.FormattingEnabled = true;
            cmbRatingGames.Location = new Point(384, 37);
            cmbRatingGames.Name = "cmbRatingGames";
            cmbRatingGames.Size = new Size(209, 28);
            cmbRatingGames.TabIndex = 3;
            cmbRatingGames.SelectedIndexChanged += cmbRatingGames_SelectedIndexChanged;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.BackColor = Color.Transparent;
            lblRating.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRating.ForeColor = SystemColors.ControlLightLight;
            lblRating.Location = new Point(277, 34);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(92, 31);
            lblRating.TabIndex = 4;
            lblRating.Text = "Rating: ";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loginPicture;
            ClientSize = new Size(982, 493);
            Controls.Add(lblRating);
            Controls.Add(cmbRatingGames);
            Controls.Add(lblCaption);
            Controls.Add(btnLogOut);
            Controls.Add(dgvGamesWindow);
            Name = "frmMain";
            Text = "MiniSteam";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGamesWindow).EndInit();
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
        private Label lblCaption;
        private ComboBox cmbRatingGames;
        private Label lblRating;
    }
}
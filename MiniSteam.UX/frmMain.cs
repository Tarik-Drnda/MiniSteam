using MiniSteam.Infrastructure;

namespace MiniSteam.UX
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            dgvGamesWindow.AutoGenerateColumns = false;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UcitajDGV();
        }

        private void UcitajDGV()
        {
            dgvGamesWindow.DataSource = null;
            dgvGamesWindow.DataSource = InMemoryDB.games;
            dgvGamesWindow.ForeColor = Color.Green;
            dgvGamesWindow.BackgroundColor = Color.White;

        }
    }
}
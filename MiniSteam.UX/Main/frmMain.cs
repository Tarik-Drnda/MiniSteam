using MiniSteam.Data;
using MiniSteam.Infrastructure;
using MiniSteam.UX.Tools;

namespace MiniSteam.UX
{
    public partial class frmMain : Form
    {
        protected User _loggedUser { get; set; }
        public frmMain(User? loggedUser)
        {
            InitializeComponent();
            dgvGamesWindow.AutoGenerateColumns = false;
            _loggedUser = loggedUser ?? new User();
            //_loggedUser.games = InMemoryDB.games.ToList();
            LoadRatings();
            LoadUserGames();

        }

        private void LoadRatings()
        {
            cmbRatingGames.DataSource = new List<int>() { 1, 2, 3, 4, 5 };
        }

        private void LoadUserGames()
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void UcitajDGV()
        {
            dgvGamesWindow.DataSource = null;
            int r = (int)cmbRatingGames.SelectedItem;
            var listGames = InMemoryDB.games.Where(g => g.Rating == r).ToList();
            if (listGames.Count > 0)
            {
                dgvGamesWindow.DataSource = listGames;
                dgvGamesWindow.ForeColor = Color.Green;
                dgvGamesWindow.BackgroundColor = Color.White;
            }

        }

        private void cmbRatingGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajDGV();
        }
    }
}
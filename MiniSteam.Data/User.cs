namespace MiniSteam.Data
{
    public sealed class User
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Game> games { get; set; }
        public User() 
        {
            games = new List<Game>();
        }

    }
}
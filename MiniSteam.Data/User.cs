namespace MiniSteam.Data
{
    public class User
    {
        public int UserID { get; set; } 
        public string UserName { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        public User() 
        {
            //games = new List<Game>();
        }
        //    public List<Game> games { get; set; }
    }
}
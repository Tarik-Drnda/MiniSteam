using MiniSteam.Data;
namespace MiniSteam.Infrastructure
{
    public sealed class InMemoryDB
    {
        public InMemoryDB() 
        {
            games=new List<Game>();
            users=new List<User>();
            
            
        }
        public static List<Game> games = GenerateGames();
        public static List<User> users = GenerateUsers();
        private static List<User> GenerateUsers()
        {
            return new List<User>()
            {
                new User()
                {
                    Ime="John",
                    Prezime="Doe",
                    Email="john@edu.fit.ba",
                    Password="1234"

                },
                new User()
                {
                    Ime="admin",
                    Prezime="admin",
                    Email="admin@edu.fit.ba",
                    Password="admin"
                }
            };
        }
        private static List<Game> GenerateGames()
        {
            return new List<Game>()
            {
                new Game()
                {
                    GameName="League of Legends",
                    Rating=5,
                    Author="Riot Games",
                    Description="This is a game MOBA/PVP 5 vs 5 where you take your champion and ..."
                },
            new Game()
            {
                GameName = "Cyberpunk 2077",
                Rating = 4,
                Author = "CD Projekt",
                Description = "An open-world RPG set in a dystopian future where players navigate the streets of Night City."
            },
            new Game()
            {
                GameName = "Minecraft",
                Rating = 5,
                Author = "Mojang",
                Description = "A sandbox game that allows players to build and explore their own blocky worlds."
            },
            new Game()
            {
                GameName = "The Witcher 3: Wild Hunt",
                Rating = 5,
                Author = "CD Projekt",
                Description = "An action RPG featuring the monster hunter Geralt of Rivia on a quest to find his adopted daughter."
            },
            new Game()
            {
                GameName = "Overwatch",
                Rating = 4,
                Author = "Blizzard Entertainment",
                Description = "A team-based multiplayer first-person shooter with a diverse cast of heroes."
            },
            new Game()
            {
               GameName = "Red Dead Redemption 2",
                Rating = 5,
                Author = "Rockstar Games",
                Description = "An epic Western-themed action-adventure game with a rich open world."
            },
            new Game()
            {
                GameName = "Fortnite",
                Rating = 3,
                Author = "Epic Games",
                Description = "A battle royale game that combines building structures with intense combat."
            },
            new Game()
            {
                GameName = "Hollow Knight",
                Rating = 4,
                Author = "Team Cherry",
                Description = "A beautifully animated indie game featuring a knight exploring a mysterious, insect-filled world."
            },
            new Game()
            {
                GameName = "Destiny 2",
                Rating = 4,
                Author = "Bungie",
                Description = "A multiplayer online shooter with a mix of PvE and PvP elements set in a sci-fi universe."
            },
            new Game()
            {
                GameName = "Among Us",
                Rating = 4,
                Author = "InnerSloth",
                Description = "A social deduction game where players work together to complete tasks while trying to identify impostors among them."
            },
            new Game()
            {
               GameName = "Assassin's Creed Valhalla",
                Rating = 4,
                Author = "Ubisoft",
                Description = "An action RPG that follows the Viking warrior Eivor's journey in England during the Dark Ages."
            }
            };
        }
    }
}
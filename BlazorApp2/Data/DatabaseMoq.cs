using BlazorApp2.Models;

namespace BlazorApp2.Data
{
    public static class DatabaseMoq
    {
        public static List<AccountModel> Accounts { get; set; }
        public static List<UserModel> Users { get; set; }
        public static List<GameModel> Games { get; set; }
        public static List<OrderModel> Orders { get; set; }   
        static DatabaseMoq()
        {
            Accounts = new List<AccountModel>();
            {
                new AccountModel()
                {
                    Id =    Guid.NewGuid(),
                    Email = "bisnesbrend@gmail.com",
                    FirstName = "Vladislav",
                    LastName = "Cherkis",
                    Phone = "0977258244",
                    Password = "123321"
                };

                new AccountModel()
                {
                    Id = Guid.NewGuid(),
                    Email = "bisnes@gmail.com",
                    FirstName = "Vlad",
                    LastName = "Cherk",
                    Phone = "0977258244",
                    Password = "123321"
                };
            };
            Users = new List<UserModel>()
            {
                new UserModel()
                {
                    Id = Guid.NewGuid(),
                    Account = Accounts[0]
                },
                new UserModel()
                {
                    Id = Guid.NewGuid(),
                    Account= Accounts[1]
                }
            }; 

            Users[0].Account.User = Users[0];
            Users[1].Account.User = Users[1];

            Games = new List<GameModel>()
            {
                new GameModel()
                {
                    Id= Guid.NewGuid(),
                    Title = "Baldur's Gate 3",
                    Image = "https://image.api.playstation.com/vulcan/ap/rnd/202308/3103/70c864f97f52f9b632d1f519a0364a5d0e2b98dc5501f058.jpg?w=620&thumb=false",
                    Price = 1000,
                    GamesOrders = new List<OrderModel>()
                },
                
                new GameModel()
                {
                    Id= Guid.NewGuid(),
                    Title = "StarCraft II",
                    Image = "https://bnetcmsus-a.akamaihd.net/cms/blog_header/2g/2G4VZH5TIWJF1602720144046.jpg",
                    Price = 1000,
                    GamesOrders = new List<OrderModel>()
                }
            };

            var ordersVladislav = new List<OrderModel>()
            {
                new OrderModel()
                {
                    Id = Guid.NewGuid(),
                    Game = Games[0],
                    User = Users[0]
                },
                

            };

            var ordersVlad = new List<OrderModel>()
            {
                new OrderModel()
                {
                    Id = Guid.NewGuid(),
                    Game = Games[0],
                    User = Users[1]
                },

                new OrderModel()
                {
                    Id = Guid.NewGuid(),
                    Game = Games[1],
                    User = Users[1]
                },

            };

            Orders = new List<OrderModel>();
            Orders.AddRange(ordersVladislav);
            Orders.AddRange(ordersVlad);

            Users[0].GameOrders.AddRange(ordersVladislav);
            Users[1].GameOrders.AddRange(ordersVlad);

        }
 
    }
}
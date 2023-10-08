using BlazorApp2.Models;

namespace BlazorApp2.Data
{
    public static class DatabaseMoq
    {
        public static List<AccountModel> Accounts { get; set; }
        public static List<UserModel> Users { get; set; }

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

        }
 
    }
}
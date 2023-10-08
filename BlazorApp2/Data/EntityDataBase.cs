using BlazorApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Data
{
    public class EntityDataBase : DbContext
    {
        public  DbSet<AccountModel> Accounts { get; set; }
        public  DbSet<UserModel> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=gamesgrad;Trusted_Connection=True;");
        }
    }
}

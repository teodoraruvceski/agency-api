using Agencija_Back.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agencija_Back.DataBase
{
    public class ProjectDbContext :DbContext
    {
        public DbSet<Company> companies { get; set; }
        public DbSet<User> users{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AgencijaZaZaposljavanje;";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

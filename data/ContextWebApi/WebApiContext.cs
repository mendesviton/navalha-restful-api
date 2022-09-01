using data.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.ContextWebApi
{
    internal class WebApiContext : DbContext
    {
        #region Props
        

        public DbSet<BarberModel> Barber { get; set; }
        public DbSet<AdressModel> Adress { get; set; }
        public DbSet<BarberShopModel> BarberShop { get; set; }
        public DbSet<ServicesModel> Service { get; set; }
        public DbSet<ClientModel> Client { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=zuplae.vps-kinghost.net;" +
                "Port=5444;" +
                "Database=postgres;" +
                "UserId=postgres;" +
                "Password=123456;" 
                );
        }
    }
}

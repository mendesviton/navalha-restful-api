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
        public DbSet<ClientModel> Client { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;" +
                "Port=5432;" +
                "Database=postgres;" +
                "UserId=postgres;" +
                "Password=123456");
        }
    }
}

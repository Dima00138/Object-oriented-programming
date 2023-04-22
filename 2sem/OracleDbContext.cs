using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CourseWork
{
    public class OracleDbContext : DbContext
    {
        public OracleConnection conn;
        public DbSet<Shedule> Shedules { get; set; }
        public DbSet<Route> Route { get; set; }
        public OracleDbContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer<OracleDbContext>(null);
            conn = new OracleConnection(connectionString);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Shedule>().HasRequired(o => o.Route)
                .WithMany(c => c.Shedules)
                .HasForeignKey(o => o.RouteId);
        }
    }
}

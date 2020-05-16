
using System.Data.Entity;

namespace Domain.DBContext
{
    public class AnalizDBContext
    {
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Consequence> Consequences { get; set; }
        public DbSet<Threat> Threats { get; set; }
        public DbSet<Vulnerability> Vulnerabilities { get; set; }
    }
}
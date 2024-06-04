using Baitapbuoi19.Models;
using Microsoft.EntityFrameworkCore;

namespace Baitapbuoi19.DataAccess.DTO
{
    public class StudentDBcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PBSFM7Q;Initial Catalog=Baitapbuoi16;Integrated Security=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;TrustServerCertificate=True");
        }
        public DbSet<Students> students { get; set; }
    }
}

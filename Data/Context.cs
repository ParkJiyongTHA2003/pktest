using Microsoft.EntityFrameworkCore;
using PakinProject.Models;

namespace PakinProject.Data
{
    public class PakinProjectContext : DbContext
    {
        public PakinProjectContext(DbContextOptions<PakinProjectContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; } // เพิ่ม DbSet สำหรับ User
    }
}

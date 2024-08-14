using HCLSWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace HCLSWebAPI.HCLSContext
{
    public class HCLSContextPro : DbContext
    {

        public HCLSContextPro() { }
        public HCLSContextPro(DbContextOptions<HCLSContextPro> options) : base(options)
        {


        }
        public DbSet<AdminDetail> AdminDetails { get; set; }

        public DbSet<Admin> Admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BHANUPRASANNA\\SQLEXPRESS;Uid=sa;password=12345;database=DataS");
        }

    }
}

using _1.InAndOut_01.Models;
using Microsoft.EntityFrameworkCore;

namespace _1.InAndOut_01.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet <Item> Items { get; set; }
    }   
}

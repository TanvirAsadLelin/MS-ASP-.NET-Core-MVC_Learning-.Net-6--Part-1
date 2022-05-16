
using LearnASP.NETCoreMVC_DotNet_6_WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnASP.NETCoreMVC_DotNet_6_WebApp.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } 
    }
}

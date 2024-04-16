using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApiCoreProject.Models
{
    public class ApiDbContext : DbContext
    {

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {


        }
       
        public DbSet<Student> Students { get; set; }


    }
}

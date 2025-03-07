// filepath: MyApiServer/Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using OLPServer.Entities;

namespace OLPServer.Data
{
   public class ApplicationDbContext : DbContext
   {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
      {
      }

      // Define your DbSets here
      public DbSet<User> Users { get; set; }
      public DbSet<KDQuestion> KDQuestions { get; set; }
   }
}
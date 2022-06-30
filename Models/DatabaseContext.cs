using Microsoft.EntityFrameworkCore;

namespace StudentsBlazorApp.Models
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Classes> classes { get; set; }
        public DbSet<CountriesMaster> countries { get; set; }
        public DbSet<Students> students { get; set; }

        public string DbPath { get; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {
            var folder = Environment.CurrentDirectory;
            //var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(folder, "studentsDB.db");


        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite($"Data Source={DbPath}");


    }
}

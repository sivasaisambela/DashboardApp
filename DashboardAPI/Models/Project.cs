using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardAPI.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

        [NotMapped]
       // [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateOfStart { get; set; }

        public int TeamSize { get; set; }

    }

    public class TaskManagerDbContext: DbContext
    {
        public DbSet<Project>  Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("data source=(localdb)\\MSSQLLocalDB;integrated security=yes;initial catalog=TaskManager;User Id=CORTLAND\\QD107;Password=Welcome2AD!;");
        }
    }
}

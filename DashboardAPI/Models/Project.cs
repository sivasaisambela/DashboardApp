using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DashboardAPI.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }

       // [NotMapped]
       //// [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
       // public DateTime DateOfStart { get; set; }

        public int TeamSize { get; set; }

    }

  
}

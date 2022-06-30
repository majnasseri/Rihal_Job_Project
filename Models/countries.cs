using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsBlazorApp.Models
{
    [Table("countries_master")]
    public class CountriesMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column("country_name")]
        public string CountryName { get; set; }
        [Column("students_list")]
        public List<Students> StudentsList { get; set; }
    }
}

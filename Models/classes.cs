using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsBlazorApp.Models
{
    [Table("classes")]
    public class Classes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column("class_name")]
        public string ClassName { get; set; }
        [Column("students_list")]
        public List<Students>  studentsList { get; set; }
    }
}

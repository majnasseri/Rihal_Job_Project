using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsBlazorApp.Models
{
    [Table("students")]
    public class Students
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("student_name")]
        public string StudentName { get; set; }
        [DataType(DataType.Date)]
        [Column("date_of_birth")]
        [DisplayFormat(DataFormatString = "{0:dd-M-yyyy}")]
        public DateTime DateOfBirth { get; set; }
        [Column("student_class")]
        public Classes StudentClass { get; set; }
        [Column("student_country")]
        public CountriesMaster StudentCountry { get; set; }

    }
}

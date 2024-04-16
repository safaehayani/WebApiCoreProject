using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCoreProject.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName="varchar(200)")]
        public string Name { get; set; } = "";

        public int Age { get; set; }
        public int ContactNumber { get; set;}
       


    }
}

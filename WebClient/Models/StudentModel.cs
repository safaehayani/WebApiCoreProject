using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebClient.Models
{
    public class StudentModel
    {

        public int Id { get; set; }

        public string Name { get; set; } = "";

        public int Age { get; set; }
        public int ContactNumber { get; set; }
    }
}

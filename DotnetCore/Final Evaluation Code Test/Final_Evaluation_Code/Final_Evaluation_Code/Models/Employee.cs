using System.ComponentModel.DataAnnotations;

namespace Final_Evaluation_Code.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Location { get; set; }
    }
}

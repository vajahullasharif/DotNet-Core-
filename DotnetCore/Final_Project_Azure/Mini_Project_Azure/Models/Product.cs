using System.ComponentModel.DataAnnotations;

namespace Mini_Project_Azure.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string productName { get; set; }

        public float Price { get; set; }
        public string Brand { get; set; }
        public DateTime MaufactureDate { get; set; }
        public DateTime ExpirationDate { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace SatrAspProject.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a Product Name")]
        public string Name { get; set; }
        [Required]

        public decimal Price { get; set; }
    }
}

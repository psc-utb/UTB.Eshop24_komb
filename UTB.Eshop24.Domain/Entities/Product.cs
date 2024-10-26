using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Eshop24.Domain.Entities
{
    [Table(nameof(Product))]
    public class Product : Entity
    {
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public double Price { get; set; }
        public string? ImageSrc { get; set; }
    }
}

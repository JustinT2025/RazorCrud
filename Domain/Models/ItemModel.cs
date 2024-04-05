using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UI.Models
{
    public class ItemModel
    {
        [Required]
        public int Id { get; set; }
        [Display(Name = "Item Name")]
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Range(0, 1000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]

        [Required]
        public decimal Price { get; set; }

    }

}

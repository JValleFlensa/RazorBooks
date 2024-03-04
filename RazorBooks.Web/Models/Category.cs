using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorBooks.Web.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Debe escribir un nombre")]
        public string Name { get; set; } = null!;
        [DisplayName("Orden de Visualización")]
        [Required(ErrorMessage = "Debe escribir un orden de visualización")]
        [Range(1, 100, ErrorMessage = "El valor del {0} debe estar entre {1} y {2}")]
        [Column("Order")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}

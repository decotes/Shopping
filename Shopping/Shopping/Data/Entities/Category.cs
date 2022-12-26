using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [DisplayName("Categoría")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    }
}

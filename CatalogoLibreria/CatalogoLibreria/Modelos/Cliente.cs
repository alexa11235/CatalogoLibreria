using System.ComponentModel.DataAnnotations;

namespace CatalogoLibreria.Modelos
{
    public class Cliente
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El correo es requerido")]
        [EmailAddress(ErrorMessage = "El correo no es válido")]
        [StringLength(100, ErrorMessage = "El correo no puede tener más de 100 caracteres")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "El teléfono es requerido")]
        [StringLength(10, ErrorMessage = "El teléfono no puede tener más de 10 caracteres")]
        public string? Telefono { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace QuickMusic.Admin.Models
{
    public class Genero
    {
         
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La imagen  es requerida")]
        public string Imagen { get; set; }
    }
}


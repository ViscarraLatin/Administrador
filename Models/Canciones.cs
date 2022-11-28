using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace QuickMusic.Admin.Models
{
    public class Canciones
    {
        public int Id { get; set; }

        [ForeignKey("Artista")]
        [Required(ErrorMessage = "Artista es obligatorio")]
        [Display(Name = "Artista")]
        public int Id_Artista { get; set; }

        [ForeignKey("Genero")]
        [Required(ErrorMessage = "Genero es obligatorio")]
        [Display(Name = "Genero")]
        public int Id_Genero { get; set; }

        [Required(ErrorMessage = "Titulo es obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Imagen es obligatorio")]
        [StringLength(200, ErrorMessage = "Maximo 200 caracteres")]
        public string Imagen { get; set; }

        [Required(ErrorMessage = "Cancion es obligatorio")]
        [StringLength(200, ErrorMessage = "Maximo 200 caracteres")]
        public string Cancion { get; set; }



    }
}

using System.ComponentModel.DataAnnotations;

namespace ExamenParcial
{
    public class ClaseLibro
    {
        /*Título
Autor
Género
Año de publicación*/
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string Titulo {  get; set; }
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string Autor {  get; set; }
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string AñoPublicacion { get; set; }


    }
}

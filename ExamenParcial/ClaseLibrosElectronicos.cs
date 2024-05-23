using System.ComponentModel.DataAnnotations;

namespace ExamenParcial
{
    public class ClaseLibrosElectronicos:ClaseLibro
    {
        /*Libros Electrónicos*/
        /*Formato (PDF, EPUB, MOBI, etc.)
Tamaño del archivo*/
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string Formato {  get; set; }
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string Tamaño { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ExamenParcial
{
    public class ClaseRevistas:ClaseLibro
    {
        /*Volumen
Número de ejemplar*/
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string Volumen { get; set; }
        [Required(ErrorMessage = "Este campo es requerido llenarla")]
        public string NumeroEjemplar { get; set; }
    }
}

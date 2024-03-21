using System.ComponentModel.DataAnnotations;

namespace ExamenApp2.Modelo
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La dirección es obligatoria.")]
        public string Direccion { get; set; }

        // Agrega los demás atributos necesarios aquí
    }
}

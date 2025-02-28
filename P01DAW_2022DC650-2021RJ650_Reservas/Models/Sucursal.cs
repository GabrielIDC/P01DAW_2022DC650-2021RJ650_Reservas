using System.ComponentModel.DataAnnotations;

namespace P01DAW_2022DC650_2021RJ650_Reservas.Models
{
    public class Sucursal
    {
        [Key]
        public int IdSucursal { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required, MaxLength(255)]
        public string Dirección { get; set; }

        [Required, MaxLength(15)]
        public string Teléfono { get; set; }

        [Required]
        public int NumeroEspacios { get; set; }
    }
}

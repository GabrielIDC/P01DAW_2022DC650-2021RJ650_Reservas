using System.ComponentModel.DataAnnotations;
namespace P01DAW_2022DC650_2021RJ650_Reservas.Models
{
    public class Parqueo
    {
        [Key]
        public int IdEspacio { get; set; }

        [Required]
        public int Número { get; set; }

        [Required, MaxLength(100)]
        public string Ubicación { get; set; }

        [Required]
        public decimal CostoPorHora { get; set; }

        [Required, MaxLength(20)]
        public string Estado { get; set; }  // Disponible u Ocupado

        [Required]
        public int IdSucursal { get; set; }
    }
}

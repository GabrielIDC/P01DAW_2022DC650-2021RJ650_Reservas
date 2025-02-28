using System.ComponentModel.DataAnnotations;
namespace P01DAW_2022DC650_2021RJ650_Reservas.Models
{
    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }

        [Required]
        public int IdUsuario { get; set; }

        [Required]
        public int IdEspacio { get; set; }

        [Required]
        public DateTime FechaReserva { get; set; }

        [Required]
        public TimeSpan HoraInicio { get; set; }

        [Required]
        public int CantidadHoras { get; set; }

        [Required, MaxLength(20)]
        public string Estado { get; set; }  // Activa o Cancelada
    }
}

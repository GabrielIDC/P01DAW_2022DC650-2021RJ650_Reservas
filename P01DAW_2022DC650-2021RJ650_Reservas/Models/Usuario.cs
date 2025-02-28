using System.ComponentModel.DataAnnotations;
namespace P01DAW_2022DC650_2021RJ650_Reservas.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required, MaxLength(100)]
        public string Correo { get; set; }

        [Required, MaxLength(15)]
        public string Telefono { get; set; }

        [Required, MaxLength(255)]
        public string Contraseña { get; set; }

        [Required, MaxLength(50)]
        public string Rol { get; set; }  
    }
}

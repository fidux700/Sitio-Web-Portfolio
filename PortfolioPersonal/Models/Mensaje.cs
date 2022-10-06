
using System.ComponentModel.DataAnnotations;

namespace PortfolioPersonal.Models
{
	public class Mensaje
	{
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        [MaxLength(100, ErrorMessage = "La cantidad de caracteres permitida es hasta 100")]

        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio")]
        [EmailAddress(ErrorMessage = "Debes ingresar un email de contacto")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo del mensaje es obligatorio")]
        [MaxLength(200, ErrorMessage = "La cantidad de caracteres permitida es hasta 200")]
        public string TuMensaje { get; set; }

	}
}

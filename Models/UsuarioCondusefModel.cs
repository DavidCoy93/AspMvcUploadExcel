using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssurantAIZ.Models
{
	public class UsuarioCondusefModel
	{
		[DisplayName("Clave")]
		[Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese una clave")]
		public string Key { get; set; }
        [DisplayName("Usuario")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese un nombre de usuario")]
        public string UserName { get; set; }
        [DisplayName("Contraseña")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese una contraseña")]
        public string Password { get; set; }
	}
}
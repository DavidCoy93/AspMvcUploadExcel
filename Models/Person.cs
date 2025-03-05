using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssurantAIZ.Models
{
	public class Person
	{
		[Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese un nombre")]
		public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese la edad")]
        public int Age { get; set; }
		public bool IsMarried { get; set; }
	}
}
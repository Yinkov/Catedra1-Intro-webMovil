using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace catedra1.src.model
{
    public class User
    {
        [Key]
        public int id {get;set;}
        [Required]
        public string rut {get;set;} = string.Empty;
        [Length(3, 100)]
        public string nombre {get;set;} = string.Empty;
        [Required]
        public string correo {get;set;} = string.Empty;
        [Required]
        [RegularExpression(@"^(masculino|femenino|otro|prefiero no decirlo)$")]
        public string genero {get;set;} = string.Empty;
        [Required]
        public DateTime fecha {get;set;}
    }
}
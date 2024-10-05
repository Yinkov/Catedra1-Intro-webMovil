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
        public int Id {get;set;}
        public required string Rut {get;set;} = string.Empty;
        [StringLength(100, MinimumLength = 3)]
        public required string Nombre {get;set;} = string.Empty;
        [RegularExpression(@"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$")]
        public required string Correo {get;set;} = string.Empty;
        [RegularExpression(@"masculino|femenino|otro|prefiero no decirlo")]
        public required string Genero {get;set;} = string.Empty;
        public required DateOnly FechaNacimiento {get;set;}
    }
}
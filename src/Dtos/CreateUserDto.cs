using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace catedra1.src.Dtos
{
    public class CreateUserDto
    {
        public required string Rut {get;set;} = string.Empty;
        [StringLength(100, MinimumLength = 3)]
        public required string Nombre {get;set;} = string.Empty;
        [RegularExpression(@"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "El formato del correo es inválido.")]
        public required string Correo {get;set;} = string.Empty;
        [RegularExpression(@"masculino|femenino|otro|prefiero no decirlo")]
        public required string Genero {get;set;} = string.Empty;
        public required DateOnly FechaNacimiento {get;set;}
    }
}
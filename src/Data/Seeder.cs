using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catedra1.src.model;

namespace catedra1.src.Data
{
    public class Seeder
    {
        public static async Task Seed(AplicationDBcontext context)
        {
            if (context.users.Any()){
                return;
            }
            var generos = new string[] { "masculino", "femenino", "otro", "prefiero no decirlo"  };
            var correos = new string[] { "gmail.com", "alumnos.ucn.cl"};
            var random = new Random();
            

            for (int i = 0; i < 20; i++)
            {
                int año =random.Next(1900, 2024);
                int mes = random.Next(1, 13);
                var user = new User
                {
                    Rut = random.Next(1000000, 25000000).ToString()+ "-" + random.Next(1, 9),
                    Nombre = $"Nombre {i}",
                    Genero = generos[random.Next(0, generos.Length)],
                    Correo = $"Correo{i}@" + correos[random.Next(0, correos.Length)],
                    FechaNacimiento = new DateOnly(año,mes, random.Next(1, DateTime.DaysInMonth(año, mes) + 1))
                };

                await context.users.AddAsync(user);
            }

            await context.SaveChangesAsync();
        }
    }
}
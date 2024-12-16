using SuperheroesAPI.Models;

namespace SuperheroesAPI.Services
{
    public static class SuperheroeFactory
    {
        public static Superheroe CrearSuperheroe(string tipo, string nombre)
        {
            return tipo.ToLower() switch
            {
                "arquero" => new Arquero { Nombre = nombre, Fuerza = 3 },
                "mago" => new Mago { Nombre = nombre, Fuerza = 4 },
                "guerrero" => new Guerrero { Nombre = nombre, Fuerza = 5 },
                _ => throw new ArgumentException("Tipo de superhéroe desconocido")
            };
        }
    }

}

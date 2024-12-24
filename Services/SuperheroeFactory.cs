using SuperheroesAPI.Models;
using System;

namespace SuperheroesAPI.Services
{
    public static class SuperHeroeFactory
    {
        public static SuperHeroe CrearSuperHeroe(string tipo)
        {
            switch (tipo.ToLower())
            {
                case "guerrero":
                    return new Guerrero();
                case "mago":
                    return new Mago();
                case "arquero":
                    return new Arquero();
                // Agrega otros tipos de superhéroes según sea necesario
                default:
                    throw new ArgumentException("Tipo de superhéroe desconocido");
            }
        }
    }

}

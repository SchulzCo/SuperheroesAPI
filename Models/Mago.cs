using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SuperheroesAPI.Models
{
    public class Mago : SuperHeroe
    {
        public Mago()
        {
            PoderEspecial = "Hechizo de Fuego";
            Fuerza = 7;
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} lanza un {PoderEspecial}, causando {Fuerza} de daño.");
        }

        public override void Defender()
        {
            Console.WriteLine($"{Nombre} crea un escudo mágico para protegerse del daño.");
        }
    }
}


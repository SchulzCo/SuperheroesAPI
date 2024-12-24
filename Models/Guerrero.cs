using static System.Runtime.InteropServices.JavaScript.JSType;
using SuperheroesAPI.Models;
using System;

namespace SuperheroesAPI.Models
{
    public class Guerrero : SuperHeroe
    {
        public Guerrero()
        {
            PoderEspecial = "Espada Maestra";
            Fuerza = 10;
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} ataca con {PoderEspecial}, causando {Fuerza} de daño.");
        }

        public override void Defender()
        {
            Console.WriteLine($"{Nombre} se defiende con su escudo, reduciendo el daño recibido.");
        }
    }
}
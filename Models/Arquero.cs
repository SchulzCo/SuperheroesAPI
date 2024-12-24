using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SuperheroesAPI.Models
{
    public class Arquero : SuperHeroe
    {
        public Arquero()
        {
            PoderEspecial = "Flecha Explosiva";
            Fuerza = 8;
        }

        public override void Atacar()
        {
            Console.WriteLine($"{Nombre} dispara una {PoderEspecial}, causando {Fuerza} de daño.");
        }

        public override void Defender()
        {
            Console.WriteLine($"{Nombre} se mueve ágilmente para esquivar los ataques.");
        }
    }

}

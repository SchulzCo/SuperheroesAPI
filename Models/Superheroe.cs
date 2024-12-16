namespace SuperheroesAPI.Models
{
    public abstract class Superheroe
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; } = 5;
        public abstract string PoderEspecial { get; }
    }
}
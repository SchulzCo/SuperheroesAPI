namespace SuperheroesAPI.Models
{
    public abstract class SuperHeroe
    {
        public string Nombre { get; set; }
        public string PoderEspecial { get; set; }
        public int Fuerza { get; set; }
        public int Salud { get; set; } = 5; // Salud máxima
        public abstract void Atacar();
        public abstract void Defender();
    }
}


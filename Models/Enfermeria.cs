
using SuperheroesAPI.Models;
using System;

namespace SuperheroesAPI.Models
{

    public class Enfermeria
    {


        private static Enfermeria _instancia;
        private int _visitasRestantes = 5;

        private Enfermeria() { }

        public static Enfermeria Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new Enfermeria();
                return _instancia;
            }
        }

        public int Visitar(SuperHeroe superHeroe, int cantidadVisitas)
        {
            if (_visitasRestantes <= 0)
            {
                throw new InvalidOperationException("No quedan visitas disponibles en la enfermería.");
            }

            int visitasEfectuadas = Math.Min(cantidadVisitas, _visitasRestantes);
            superHeroe.Salud = Math.Min(superHeroe.Salud + visitasEfectuadas, 5); // Salud máxima es 5
            _visitasRestantes -= visitasEfectuadas;

            return superHeroe.Salud;
        }
    }
}
namespace SuperheroesAPI.Models
{

        public class Enfermeria
        {
            private static Enfermeria _instancia;
            private static readonly object _lock = new object();
            private int _visitasDisponibles = 5;

            private Enfermeria() { }

            public static Enfermeria Instancia
            {
                get
                {
                    lock (_lock)
                    {
                        if (_instancia == null)
                        {
                            _instancia = new Enfermeria();
                        }
                        return _instancia;
                    }
                }
            }

            public bool PuedeRecibirVisita() => _visitasDisponibles > 0;

            public void RecibirVisita(Superheroe superheroe, int cantidadVisitas)
            {
                for (int i = 0; i < cantidadVisitas && PuedeRecibirVisita() && superheroe.Salud < 5; i++)
                {
                    superheroe.Salud++;
                    _visitasDisponibles--;
                }
            }
        }

    }

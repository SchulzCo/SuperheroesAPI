using Microsoft.AspNetCore.Mvc;
using SuperheroesAPI.Models;
using SuperheroesAPI.Services;

namespace SuperheroesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuperheroesController : ControllerBase
    {
        [HttpPost]
        [Route("crear")]
        public ActionResult<Superheroe> CrearSuperheroe(string tipo, string nombre)
        {
            try
            {
                var superheroe = SuperheroeFactory.CrearSuperheroe(tipo, nombre);
                return Ok(superheroe);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("visitarEnfermeria")]
        public ActionResult<int> VisitarEnfermeria(string tipo, string nombre, int saludActual, int cantidadVisitas)
        {
            try
            {
                var superheroe = SuperheroeFactory.CrearSuperheroe(tipo, nombre);
                superheroe.Salud = saludActual;

                var enfermeria = Enfermeria.Instancia;
                if (enfermeria.PuedeRecibirVisita())
                {
                    enfermeria.RecibirVisita(superheroe, cantidadVisitas);
                    return Ok(superheroe.Salud);
                }
                else
                {
                    return BadRequest("La enfermería ha alcanzado el límite de visitas.");
                }
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }





}

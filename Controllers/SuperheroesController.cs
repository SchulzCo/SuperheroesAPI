using Microsoft.AspNetCore.Mvc;
using SuperheroesAPI.Models;
using SuperheroesAPI.Services;

namespace SuperheroesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuperheroesController : ControllerBase
    {

        [HttpPost("crear")]
        public ActionResult<SuperHeroe> CrearSuperHeroe(string nombre, string tipo)
        {
            SuperHeroe superHeroe = SuperHeroeFactory.CrearSuperHeroe(tipo);
            superHeroe.Nombre = nombre;
            return Ok(superHeroe);
        }

        [HttpPost("accion")]
        public ActionResult AccionSuperHeroe(string nombre, string tipo, string accion)
        {
            SuperHeroe superHeroe = SuperHeroeFactory.CrearSuperHeroe(tipo);
            superHeroe.Nombre = nombre;

            if (accion.ToLower() == "atacar")
            {
                superHeroe.Atacar();
            }
            else if (accion.ToLower() == "defender")
            {
                superHeroe.Defender();
            }
            else
            {
                return BadRequest("Acción desconocida.");
            }

            return Ok();
        }

        [HttpPost("visitarEnfermeria")]
        public ActionResult<int> VisitarEnfermeria(string tipo, int salud, int cantidadVisitas)
        {
            SuperHeroe superHeroe = SuperHeroeFactory.CrearSuperHeroe(tipo);
            superHeroe.Salud = salud;
            int saludDespuesDeVisita = Enfermeria.Instancia.Visitar(superHeroe, cantidadVisitas);
            return Ok(saludDespuesDeVisita);
        }
    }
}


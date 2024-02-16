using Microsoft.AspNetCore.Mvc; //Proporciona herramientas para construir aplicaciones y servicios web utilizando el patrón de arquitectura MVC
namespace ejerciciosapi.Controllers
{
    [ApiController]  //Indica que la clase es un controlador de API
    [Route("[controller]")] //Indica la ruta del controlador
    public class Ejercicioone : ControllerBase // Proporciona funcionalidaades e caracteristicas para que la clase pueda ser utilizada como un cotrolador
    {
        private bool EsNumeroPar(long respuesta)
        {
            return respuesta % 2 == 0;
        }
        [HttpGet("{numero}")] // El decorador define y configura el comportamiento de los métodos dentro de los controladores de API
        public ActionResult<string> Get(string numero)
        {
            if (long.TryParse(numero, out long respuesta))
            {
                if (EsNumeroPar(respuesta))
                {
                    return $"{respuesta} es un número par.";
                }
                else
                {
                    return $"{respuesta} es un número impar.";
                }
            }
            else
            {
                return $"{numero} no es un número válido (Recuerda no ingresar signos, letras, simbolos, iconos, números decimales).";
            }
        }
    }
}
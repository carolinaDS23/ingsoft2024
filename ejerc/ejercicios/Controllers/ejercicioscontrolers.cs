using Microsoft.AspNetCore.Mvc;

namespace ejercicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EjerciciosController : ControllerBase
    {
        [HttpGet(Name = "ejercicio1")]
        public Object Get (int number)
        {
            bool isEven;
            if (number % 2 == 0)
            {
                isEven = true;
            }
            else
            {
                isEven = false;
            }

            return Ok(new
            {
                number = number,
                isEven = isEven
            });
        }
    }
}

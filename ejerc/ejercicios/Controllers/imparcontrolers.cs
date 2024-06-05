using Microsoft.AspNetCore.Mvc;

namespace ejercicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class imparController : ControllerBase
    {
        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult ObjectGet(int number)
        {
            bool isPar;
            if (number % 2 == 0)
            {
                // Si el número es par, se incrementa en 1 para que sea impar
                number++;
                isPar = false;
            }
            else
            {
                isPar = false;
            }

            return Ok(new
            {
                number = number,
                isPar = isPar
            });
        }
    }
}

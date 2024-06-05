using Microsoft.AspNetCore.Mvc;

namespace ejercicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EjerciciosController : ControllerBase
    {
        [HttpGet(Name = "GetPalindromeCheck")]
        public IActionResult ObjectGet(int number)
        {
            bool isPalindrome = IsPalindrome(number);

            return Ok(new
            {
                number = number,
                isPalindrome = isPalindrome
            });
        }

        private bool IsPalindrome(int number)
        {
            string numStr = number.ToString();
            char[] numArray = numStr.ToCharArray();
            Array.Reverse(numArray);
            string reversedNumStr = new string(numArray);

            return numStr.Equals(reversedNumStr, StringComparison.Ordinal);
        }
    }
}

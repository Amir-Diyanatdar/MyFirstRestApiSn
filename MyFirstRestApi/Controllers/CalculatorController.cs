using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("Calculate")]
        public IActionResult Calculate(decimal firstNumber, decimal SecondNumber, string ActionType)
        {
            decimal result;
            //=========================
            switch (ActionType)
            {
                case "+":
                    result = firstNumber + SecondNumber;
                    break;
                case "-":
                    result = firstNumber - SecondNumber;
                    break;
                case "*":
                    result = firstNumber * SecondNumber;
                    break;
                case "/":
                    result = firstNumber / SecondNumber;
                    break;
                default:
                    result = 0;
                    return NotFound();
                    
            }
            return Ok(result);

        }
    }
}

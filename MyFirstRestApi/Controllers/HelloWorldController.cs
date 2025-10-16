using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet("sayHello")]
        public string HelloWorld()
        {
            string firstMessage = "Hello, this is my first restful api!";
            return firstMessage;
        }
        //==========================================================
        [HttpGet("sayHelloAction")]
        public IActionResult sayHelloAction()
        {
            string secondMessage = "This is my second message";
            return Ok(secondMessage);
        }
        //==========================================================
        [HttpGet("sayHelloFirstName")]
        public IActionResult sayHelloFirstName(string firstName)
        {
            string thirdMessage = $"Hi! {firstName}, this is my third message";
            return Ok(thirdMessage);
        }
        //============================================================
        [HttpGet("sayHelloFullName")]
        public IActionResult sayHelloFullName(string firstName, string LastName)
        {
            string forthMessage = $"hi! {firstName} {LastName}, this is my forth Message";
            return Ok(forthMessage);
        }
        //============================================================
    }
}

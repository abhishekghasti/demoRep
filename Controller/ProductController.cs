using Microsoft.AspNetCore.Mvc;
using NewApp.Services.CheckParanthesis;

namespace NewApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        /// <summary>
        /// Get Data
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("/getResult")]
        public IActionResult Post([FromBody] string statement)
        {
            Console.WriteLine("Post method called");
            return Ok(CheckParanthesis.IsValid(statement) ? "Valid" : "Not Valid");
        }
    }
        
}
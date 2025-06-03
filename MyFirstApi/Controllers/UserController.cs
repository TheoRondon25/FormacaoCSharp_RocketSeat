using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Get()
    {
        var response = new User
        {            
            Age = 7,
            Name = "Theo"
        };

        return Ok(response);
    }    
    
    [HttpGet]
    //[Route("{id}/{nickname}")] // passando valor pela rota
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromHeader] int id, [FromHeader] string? nickname) // passando valor pelo header
    {
        var response = new User
        {
            Id = 1,
            Age = 7,
            Name = "Theo"
        };

        return Ok(response);
    }
}

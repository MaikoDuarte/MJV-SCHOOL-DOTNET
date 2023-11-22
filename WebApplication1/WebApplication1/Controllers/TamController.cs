using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class TamController: ControllerBase
{
    //GET
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "Estou no",  "Rider" };
    }
    
    
}
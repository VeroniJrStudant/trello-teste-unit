using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace trello_semana3.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class HelloController : Controller
  {
    private readonly ILogger<HelloController> _logger;

    public HelloController(ILogger<HelloController> logger)
    {
      _logger = logger;
    }

    [HttpGet]
    public string hello()
    {
      return "Hello World";
    }
  }
}
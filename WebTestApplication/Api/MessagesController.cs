using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebTestApplication.Api
{
    [Route ("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var result = _context.
            return Ok(result);
        }
    }

    private readonly Models.CrudExampleContext ;

    public MessagesController(Models.CrudExampleContext context)
    {
        _context = context;
    }
}
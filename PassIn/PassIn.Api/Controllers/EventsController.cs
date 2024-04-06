using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PassIn.Communication.Requests;

namespace PassIn.Api.Controllers
{
    [Route("[controller]")]
    public class EventsController : Controller
    {
        [HttpPost]
        public IActionResult Register([FromBody] RequestEventJson request)
        {
            return Created();
        }

    }
}
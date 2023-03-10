using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("digits")]

        public string Explode(string e)
        {
            return string.Join("", e.Select(answer => new String(answer, int.Parse(answer.ToString()))));
        }
    }
}

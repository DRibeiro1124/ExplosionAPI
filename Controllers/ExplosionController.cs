using System;
using Microsoft.AspNetCore.Mvc;


namespace ExplosionAPI.Controllers
{
    [ApiController]
    [Route("/digits")]
    public class DigitsExplosion
    {
        [HttpGet("(s)")]
        public string Explode(string s)
        {
            string solution = "";

            foreach (char c in s)
            {
                int number = int.Parse(c.ToString());

                for (int i = number; i > 0; i--)

                {
                    solution += number;
                }
            }
            return solution;

        }
    }
}


/*



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
        [HttpGet("explosion")]
        public string Explode(string str)
        {
            string result = "";

            foreach (char c in str)
            {
                int number = int.Parse(c.ToString());

                for (int i = number; i > 0; i--)
                {
                    result += number;
                }

                return result;
            }
        }
    }
}
*/
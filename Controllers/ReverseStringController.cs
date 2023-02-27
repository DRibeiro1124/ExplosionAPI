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
    public class reverseString
    {
        [HttpGet("word")]
        public string Reverse(string word)
        {
            string reverse = "";
            char[] strInChar = word.ToCharArray();

            for (int i = strInChar.Length - 1; i >= 0; i--)
            {
                reverse += strInChar[i];
            }
            return reverse;
        }
    }

}
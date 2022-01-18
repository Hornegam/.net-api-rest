using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        [HttpGet ("{id}")]
        public String GetUser(String id)
        {
           
            return $"Teste alguma coisa {id}";
        }
    }
}

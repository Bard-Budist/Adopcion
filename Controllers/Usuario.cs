using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Adopciones1.Controllers
{
    [Route("api/[controller]")]
    public class Usuario : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public string getUsuario()
        {
            return "Pablito bosudo";
        }

        public int traerSuma(int valor1, int valor2)
        {
            int resultado = valor1 + valor2;
            return resultado;
        }

    }
}
using EscuelaEri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System;
using EscuelaEri.Models;

namespace EscuelaEri.Controllers
{
    public class ErikaController : ApiController
    {
        [ActionName ("Agregar")]
        [HttpPost]

        public void post(Grupos grupos)
        {
            Model1 model = new Model1();
            model.Grupos.Add(grupos);
            model.SaveChanges();
        }
    }
}

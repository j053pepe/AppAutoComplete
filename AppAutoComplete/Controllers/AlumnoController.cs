using AppAutoComplete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppAutoComplete.Controllers
{
    public class AlumnoController : ApiController
    {
        private IeseEncuestaEntities db = new IeseEncuestaEntities();

        [HttpGet]
        [ActionName("Nombre")]
        public IHttpActionResult GetNombre(string filtro)
        {
            return Ok(
            db.Alumno.Where(al => al.Nombre.Contains(filtro))
                        .Select(al => new
                        {
                            Value = al.AlumnoId,
                            Text = al.Nombre + " " + al.Paterno + " " + al.Materno
                        }).ToList()
            );
        }
    }
}

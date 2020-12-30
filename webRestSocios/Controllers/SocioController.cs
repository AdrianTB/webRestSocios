using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webRestSocios.Context;
using webRestSocios.Model;

namespace webRestSocios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocioController : ControllerBase
    {

        // Inyectar el contexto al controlador (BDContext) al controlador(SocioController)

        private readonly BDContext context;

        public SocioController(BDContext context)
        {
            this.context = context;
        }




        // GET: api/Socio
        [HttpGet]
        public IEnumerable<tb_socios> Get()
        {
            return context.tb_socios.ToList();
        }

        // GET: api/Socio/5  -- BUSCAR POR ID 
        [HttpGet("{id}")]
        public tb_socios Get(string id)
        {
            var obj_socio = context.tb_socios.FirstOrDefault(c => c.id_socio == id);
            return obj_socio;
        }

        // POST: api/Socio   --  AGREGAR 
        [HttpPost]
        public ActionResult Post([FromBody] tb_socios obj_socio)
        {

            try
            {
                context.tb_socios.Add(obj_socio);
                context.SaveChanges();

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }

        }

        // PUT: api/Socio/5
        [HttpPut("{id}")]
        public ActionResult Put(String id, [FromBody] tb_socios obj_socio)
        {

            if (obj_socio.id_socio == id)
            {
                try
                {
                    context.Entry(obj_socio).State = EntityState.Modified;
                    context.SaveChanges();

                    return Ok();
                }
                catch (Exception e)
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(String id)
        {

            var obj_socio = context.tb_socios.FirstOrDefault(c => c.id_socio == id);

            if (obj_socio != null)
            {

                try
                {
                    context.tb_socios.Remove(obj_socio);
                    context.SaveChanges();
                    return Ok();
                }
                catch (Exception e)
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }

        }
    }
}

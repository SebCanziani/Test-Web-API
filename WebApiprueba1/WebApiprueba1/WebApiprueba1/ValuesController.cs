using Microsoft.AspNetCore.Mvc;
using Negocio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiprueba1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    { 
        
        
        
        ProductosApi productosApi = new ProductosApi();


        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var productos = productosApi.GetAll();

                if (productos == null || !productos.Any())
                {
                    return NoContent(); // 204 No Content no hay productos
                }

                return Ok(productos); // 200 OK
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); // Devuelve 400 Bad Request con el mensaje de la excepción
            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var producto = productosApi.GetById(id);

                if (producto == null)
                {
                    return NotFound(); 
                }
                return Ok(producto); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }


        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;
using Negocio;
using Negocio.Modelos;
using System.Text.Json.Nodes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiprueba1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {



        ProductosApi productosApi = new ProductosApi();


        // GET: api/<ValuesController>
        [HttpGet]
        public List<Producto> GetProductos()
        {

            ProductosApi prodApi = new ProductosApi();

            return prodApi.GetAll();
        }


        [HttpGet("GetCategorias")]
        public List<string> GetCategorias()
        {

            ProductosApi prodApi = new ProductosApi();

            return prodApi.GetAllCategorias();
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

        public IActionResult Post([FromBody] Producto producto)
        {
            Producto productoN;
            try
            {
                productoN = productosApi.Post(producto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return StatusCode(201, productoN);
        }




        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Producto product)
        {
            try
            {
                product.Id = id;
                var productoActualizado = productosApi.Put(product);
                if (productoActualizado == null)
                {
                    return NotFound(); 
                }
                return Ok(productoActualizado); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
           
    }
    // DELETE api/<ValuesController>/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {

        try
        {
            var eliminado = productosApi.Delete(id);

            if (eliminado == 0) 
            {
                return NotFound(); 
            }

            return NoContent(); 
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message); 
        }
    }

     
        }
    }


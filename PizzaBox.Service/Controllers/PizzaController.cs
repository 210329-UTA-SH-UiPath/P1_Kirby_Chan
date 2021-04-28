using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaBox.Domain.Abstractions;
using PizzaBox.Domain.Models;
using System.Net.Mime;

namespace PizzaBox.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaRepository repo;
        public PizzaController(IPizzaRepository repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Crust> Get()
        {
            try
            {
                return Ok(repo.GetAllPizzas());
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
        [HttpGet("{id:int}")]//"api/Crust/1"
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Crust> Get(int id)
        {
            try
            {
                return Ok(repo.GetPizzaById(id));
            }
            catch (Exception ex)
            {
                return NotFound($"The pizza Id - {id} does not exist" + ex.Message);
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[Consumes("application/json")]
        [Consumes(MediaTypeNames.Application.Json)]
        public IActionResult Post([FromBody] Pizza Pizza) //model binder of asp.net core will look for this parameter from request body
        {
            if (Pizza == null)
            {
                return BadRequest("The pizza you are trying to add is empty");
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    repo.AddPizza(Pizza);
                    return CreatedAtAction(nameof(Get), new { id = Pizza.ID }, Pizza);
                }
            }
        }
    }
}

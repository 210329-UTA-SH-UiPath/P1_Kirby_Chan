using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using PizzaBox.Domain.Abstractions;
using PizzaBox.Domain.Models;

namespace PizzaBox.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrustController : ControllerBase
    {
        private readonly ICrustRepository repo;
        public CrustController(ICrustRepository repo)
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
                return Ok(repo.GetAllCrusts());
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
                return Ok(repo.GetCrustById(id));
            }
            catch (Exception ex)
            {
                return NotFound($"The crust Id - {id} does not exist" + ex.Message);
            }
        }
    }
}
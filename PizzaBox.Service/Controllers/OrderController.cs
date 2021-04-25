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
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository repo;
        public OrderController(IOrderRepository repo)
        {
            this.repo = repo;
        }
        [HttpGet("customer/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Order> GetCustomerOrders([FromRoute] int id)
        {
            try
            {
                return Ok(repo.GetOrderHistoryByCustomer(id));
            }
            catch (Exception ex)
            {
                return StatusCode(404, ex.Message);
            }
        }
        [HttpGet("store/{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Order> GetStoreOrders([FromRoute] int id)
        {
            try
            {
                return Ok(repo.GetOrderHistoryByStore(id));
            }
            catch (Exception ex)
            {
                return StatusCode(404, ex.Message);
            }
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[Consumes("application/json")]
        [Consumes(MediaTypeNames.Application.Json)]
        public IActionResult PostOrder([FromBody] Order Order) //model binder of asp.net core will look for this parameter from request body
        {
            if (Order == null)
            {
                return BadRequest("The order you are trying to add is empty");
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    repo.AddOrder(Order);
                    return CreatedAtAction(nameof(GetCustomerOrders), new { id = Order.ID }, Order);
                }
            }
        }
    }
}

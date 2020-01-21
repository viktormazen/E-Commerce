using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace WebApi.Controllers
{
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("Api/Order/GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_orderService.GetAllOrder().ToList());
        }
        [HttpGet("Api/Order/GetById")]
        public IActionResult GetById([FromQuery(Name ="id")] int id)
        {
            try
            {
                return Ok(_orderService.GetOrderById(id));
            }
            catch (Exception ex)
            {
                return BadRequest($"Order wiht id:{id} not exist! " + ex.Message );
            }
        }

        [HttpPost("Api/Order/SaveOrder")]
        public IActionResult SaveOrder([FromQuery] Order order)
        {
            try
            {
                _orderService.CreateOrder(order);
                return Ok("Successfully added order");
            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong. Please try again! Info: " + ex.Message);
            }
        }

        [HttpDelete("Api/Order/DeleteOrderById")]
        public IActionResult DeleteOrderById([FromQuery(Name ="id")]int id)
        {
            try
            {
                _orderService.DeleteOrder(id);
                return Ok("Successfully deleted order");
            }
            catch (Exception ex)
            {
                return BadRequest("Something went wrong. Please try again! Info: " + ex.Message);
            }
        }
        [HttpGet("Api/Order/GetOrderByDateRange")]
        public IActionResult GetOrderByDateRange([FromQuery]DateTime fromDate, [FromQuery]DateTime toDate)
        {
            return Ok(_orderService.GetOrdersByDateRange(fromDate, toDate));
        }
    }
}
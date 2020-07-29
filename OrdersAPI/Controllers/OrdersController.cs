using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrdersAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController
    {
        // GET api/<OrdersController>/1
        [HttpGet("{id}")]
        public IList<Order> Get(int id)
        {
            IList<Order> list = new List<Order>();
            Order o = new Order();
            o.OrderId = 1;
            o.OrderAmount = 250;
            o.OrderDate = DateTime.Now.AddDays(-50);
            list.Add(o);
            o = new Order();
            o.OrderId = 2;
            o.OrderAmount = 450;
            o.OrderDate = DateTime.Now.AddDays(-10);
            list.Add(o);
            return list;
        }
    }
}

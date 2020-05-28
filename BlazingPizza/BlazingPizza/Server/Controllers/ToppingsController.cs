﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingPizza.Server.Models;
using BlazingPizza.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Server.Controllers
{
    [Route("toppings")]
    [Route("api/[controller]")]
    [ApiController]
    public class ToppingsController : ControllerBase
    {
        private readonly PizzaStoreContext Context;
        public ToppingsController(PizzaStoreContext context)
        {
            this.Context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Topping>>> GetToppings()
        {
            return await Context.Toppings
                .OrderBy(t => t.Name).ToListAsync();
        }

    }
}

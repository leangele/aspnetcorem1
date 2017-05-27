using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega.Controllers.Resources;
using Vega.Models;
using Vega.Persistance;

namespace Vega.Controllers
{

    public class MakesController : Controller
    {
        private readonly VegaDbContext VegaDbContext;
        private readonly IMapper mapper;
        public MakesController(VegaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.VegaDbContext = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await VegaDbContext.Makes.Include(m => m.Models).ToListAsync();
            return Mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}
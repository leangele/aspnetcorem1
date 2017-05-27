using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vega.Controllers.Resources;
//using Vega.Core.Models;
using Vega.Models;

namespace Vega.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            //CreateMap<Make, KeyValuePairResource>();
            //CreateMap<Model, KeyValuePairResource>();
        }
        
    }
}
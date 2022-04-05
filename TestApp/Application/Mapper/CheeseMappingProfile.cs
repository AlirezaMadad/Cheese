using Application.Commands;
using Application.Responses;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper
{
    public class CheeseMappingProfile : Profile
    {
        public CheeseMappingProfile()
        {
            CreateMap<Core.Entities.Cheese, CheeseResponse>().ReverseMap();
            CreateMap<Core.Entities.Cheese, CreateCheeseCommand>().ReverseMap();
        }
    }
}

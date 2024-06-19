using AutoMapper;
using FiorelloApi.DTOs.Categories;
using FiorelloApi.Models;

namespace FiorelloApi.Mappers
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDto>()

        }
    }
}

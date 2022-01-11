using AutoMapper;
using MyLittleBluRayThequeProject.DTOs;
using MyLittleBluRayThequeProject.Entity;

namespace MyLittleBluRayThequeProject.Mappers
{
    public class BluRayMapper : Profile
    {

        public BluRayMapper()
        {
            CreateMap<BluRayDto, BluRay>();
            CreateMap<BluRay, BluRayDto>();
        }
    }
}

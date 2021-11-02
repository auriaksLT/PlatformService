using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;


// Auto-Maping profiles. Checked if exists when requested by .Map<> function  
namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Mapping models: 
            // Source -> Target respectivelly
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>(); 
        }
    }
}
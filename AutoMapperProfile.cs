using AutoMapper;
using donet_test.Models;
using donet_test.Dtos.Character;

namespace donet_test
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
           CreateMap<Character, GetCharacterDto>();
           CreateMap<AddCharacterDto, Character>();
        }
    }
}
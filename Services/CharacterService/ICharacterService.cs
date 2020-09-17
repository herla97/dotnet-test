using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using donet_test.Models;

namespace donet_test.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(Guid id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}
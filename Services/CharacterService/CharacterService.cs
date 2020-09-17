using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

using donet_test.Models;

namespace donet_test.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            // new Character{Id = System.Guid.NewGuid(), Name = "Salvador"}
            new Character{Id = Guid.Parse("f545a9ef-1949-485d-8358-3cd27cc225f9"), Name = "Salvador"}
        };

        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();

            // Add new uuid
            newCharacter.Id = System.Guid.NewGuid();
            characters.Add(newCharacter);

            serviceResponse.Data = characters;

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {

            ServiceResponse<List<Character>> serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(Guid id)
        {
            ServiceResponse<Character> serviceResponse = new ServiceResponse<Character>();
            serviceResponse.Data = characters.FirstOrDefault(c => c.Id == id);

            return serviceResponse;
        }
    }
}
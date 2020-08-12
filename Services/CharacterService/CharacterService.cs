using System;
using System.Collections.Generic;
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

        public List<Character> AddCharacter(Character newCharacter)
        {
            // Add new uuid
            newCharacter.Id = System.Guid.NewGuid();

            characters.Add(newCharacter);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(Guid id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}
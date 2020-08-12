using System;
using System.Collections.Generic;
using donet_test.Models;

namespace donet_test.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAllCharacters();
        Character GetCharacterById(Guid id);
        List<Character> AddCharacter(Character newCharacter);
    }
}
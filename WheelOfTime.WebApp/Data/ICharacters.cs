using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelOfTime.WebApp.Models.CharacterMods;

namespace WheelOfTime.WebApp.Data
{
    public interface ICharacters
    {
        public bool CreateCharacter(CharacterCreate model);
        public IEnumerable<CharacterListItem> GetCharacters();
        public CharacterDetail GetCharacterById(int id);
        public bool UpdateCharacter(CharacterEdit character);
        public bool DeleteCharacter(int characterId);

    }
}

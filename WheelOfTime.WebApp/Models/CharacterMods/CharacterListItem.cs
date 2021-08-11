using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelOfTime.WebApp.Data;

namespace WheelOfTime.WebApp.Models.CharacterMods
{
    public class CharacterListItem
    {
        public int CharacterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string Ability { get; set; }
        public string Image { get; set; }
        public virtual string Birthplace { get; set; }
        public int NationId { get; set; }
        public virtual List<Chapter> Chapters { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelOfTime.WebApp.Models.CharacterMods;
using WheelOfTime.WebApp.Models.NationMods;

namespace WheelOfTime.WebApp.Data
{
    public interface INations
    {
        public bool CreateNation(NationCreate model);
        public IEnumerable<NationListItem> GetNations();
        public NationDetail GetNationById(int Id);
        public bool UpdateNation(NationEdit nation);
        public bool DeleteNation(int id);

    }
}

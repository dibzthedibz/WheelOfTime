﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelOfTime.WebApp.Models.CharacterMods;
using WheelOfTime.WebApp.Models.NationMods;

namespace WheelOfTime.WebApp.Data
{
    public class NationsRepository
    {
        private readonly Guid _userId;
        public NationsRepository(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateNation(NationCreate model)
        {
            var entity = new Nation()
            {
                OwnerId = _userId,
                NationName = model.NationName,
                Terrain = model.Terrain,
                Trades = model.Trades
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Nations.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<NationListItem> GetNations()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Nations.Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                        new NationListItem
                        {
                            NationId = e.NationId,
                            NationName = e.NationName,
                        }
                    );
                return query.ToArray();
            }
        }

        public NationDetail GetNationById(int Id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Nations.Single(e => e.NationId == Id && e.OwnerId == _userId);
                return new NationDetail
                {
                    NationId = entity.NationId,
                    NationName = entity.NationName,
                    Terrain = entity.Terrain,
                    Trades = entity.Trades,
                    Characters = entity.Characters
                    .Select(e => new CharacterListItem()
                    {
                        CharacterId = e.CharacterId,
                        FirstName = e.FirstName,
                        LastName = e.LastName
                    }).ToList()
                };
            }
        }

        public bool UpdateNation(NationEdit nation)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Nations
                    .Single(e => e.NationId == nation.NationId && e.OwnerId == _userId);
                entity.NationName = nation.NationName;
                entity.Terrain = nation.Terrain;
                entity.Trades = nation.Trades;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteNation(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                ctx.Nations.Single(e => e.NationId == id && e.OwnerId == _userId);
                ctx.Nations.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}

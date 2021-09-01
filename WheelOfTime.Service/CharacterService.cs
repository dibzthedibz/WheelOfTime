﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelOfTime.WebApp.Data;
using WheelOfTime.WebApp.Models.CharacterMods;

namespace WheelOfTime.Service
{
    public class CharacterService
    {
        private readonly Guid _userId;
        public CharacterService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateCharacter(CharacterCreate model)
        {
            var entity = new Character()
            {
                OwnerId = _userId,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Ability = model.Ability,
                NationId = model.NationId,
                Image = model.Image
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Characters.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CharacterListItem> GetCharacters()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Characters.Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                        new CharacterListItem
                        {
                            CharacterId = e.CharacterId,
                            FirstName = e.FirstName,
                            LastName = e.LastName,
                            Ability = e.Ability,
                            Birthplace = e.Birthplace.NationName,
                            Image = e.Image,
                            Chapters = e.Chapters
                        }
                    );
                return query.ToArray();
            }
        }
        public CharacterDetail GetCharacterById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Characters.Single(e => e.CharacterId == id && e.OwnerId == _userId);
                return new CharacterDetail
                {
                    CharacterId = entity.CharacterId,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    Ability = entity.Ability,
                    NationId = entity.NationId,
                    Image = entity.Image
                };
            }
        }
        public bool UpdateCharacter(CharacterEdit character)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Characters
                        .Single(e => e.CharacterId == character.CharacterId && e.OwnerId == _userId);
                entity.FirstName = character.FirstName;
                entity.LastName = character.LastName;
                entity.Ability = character.Ability;
                entity.NationId = character.NationId;
                entity.Image = character.Image;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteCharacter(int characterId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity1 =
                ctx
                    .Chapters
                    .Single(e => e.CharacterId == characterId && e.OwnerId == _userId);
                ctx.Chapters.Remove(entity1);

                var entity =
                    ctx
                        .Characters
                        .Single(e => e.CharacterId == characterId && e.OwnerId == _userId);

                ctx.Characters.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonsterHunterAPI.Web.Models;
using MonsterHunterAPI.Domain.Models;
using MonsterHunterAPI.Domain.Services;


namespace MonsterHunterAPI.Web.Services
{
    public class WeaponService
    {
        static IWeaponService _service;

        public WeaponService(IWeaponService service)
        {
            _service = service;

        }



        public void AddWeaponToDb(WeaponDataEntryModel model)
        {

            _service.AddNewWeapon(MapWeaponToWeaponDTO(model));

        }

        private  WeaponDTO MapWeaponToWeaponDTO(WeaponDataEntryModel model)
        {
            return new WeaponDTO()
            {
                Name = model.Name,
                Rarity = model.Rarity,
                Attack = model.Attack,
                Element = model.Element,
                Sharpness = model.Sharpness,
                Slots = model.Slots,
                Affinity = model.Affinity,
                Defense = model.Defense
            };
        }
    }
}
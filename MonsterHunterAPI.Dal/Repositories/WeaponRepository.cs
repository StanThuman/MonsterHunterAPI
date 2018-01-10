using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterHunterAPI.Dal.Models;
using MonsterHunterAPI.Domain.Repositories;
using MonsterHunterAPI.Domain.Models;


namespace MonsterHunterAPI.Dal.Repositories
{
    public class WeaponRepository : IWeaponRepository
    {
        MonsterHunterContext _db;
        public WeaponRepository()
        {
            _db = new MonsterHunterContext();
        }

        const string DEBUG = "WeaponsRepository";
        public void GetAllWeapons()
        {
            System.Diagnostics.Debug.WriteLine(DEBUG + " inside get all weapons\n");
            var list = _db.Weapons.AsEnumerable<Weapon>();

            foreach(var weapon in list)
            {
                System.Diagnostics.Debug.WriteLine(weapon.Name);
                System.Diagnostics.Debug.WriteLine(weapon.Rarity);
                System.Diagnostics.Debug.WriteLine(weapon.Sharpness);
                System.Diagnostics.Debug.WriteLine(weapon.Slots);
                System.Diagnostics.Debug.WriteLine(weapon.Affinity);
            }

        }

        public void GetAllWeaponsByClass()
        {
            System.Diagnostics.Debug.WriteLine(DEBUG + "inside get all weapons by class\n");
        }

        public void GetWeapon(string weaponName)
        {
            System.Diagnostics.Debug.WriteLine(DEBUG + "inside get all weapons\n");
        }

        public void AddNewWeaponToDb(WeaponDTO model)
        {
            Weapon newWeapon = WeaponMapper(model);
            System.Diagnostics.Debug.WriteLine("INSIDE DAL layer Weapons Repo");
            System.Diagnostics.Debug.WriteLine(model.Name);
            System.Diagnostics.Debug.WriteLine(model.Attack);
            System.Diagnostics.Debug.WriteLine(model.Rarity);
            System.Diagnostics.Debug.WriteLine(model.Affinity);
            System.Diagnostics.Debug.WriteLine(model.Slots);

            //_db.Weapons.Add(WeaponMapper(model));
            //_db.SaveChanges();
        }

        private Weapon WeaponMapper(WeaponDTO model)
        {
            return new Weapon()
            {
                Name = model.Name,
                Rarity = model.Rarity,
                Attack = model.Attack,
                Sharpness = model.Sharpness,
                Slots = model.Slots,
                Affinity = model.Affinity,
                Defense = model.Defense
            };
        }






    }
}

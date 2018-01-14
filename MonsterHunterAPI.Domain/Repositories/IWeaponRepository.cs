using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterHunterAPI.Domain.Models;

namespace MonsterHunterAPI.Domain.Repositories
{
    public interface IWeaponRepository
    {
        void AddNewWeaponToDb(WeaponDTO model);
        void GetAllWeapons();
        void GetAllWeaponsByClass();        
        WeaponDTO GetWeapon(string weaponName);

        //void RemoveWeapon();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterHunterAPI.Domain.Models;

namespace MonsterHunterAPI.Domain.Services
{
    public interface IWeaponService
    {
        void AddNewWeapon(WeaponDTO model);


        //do stuff to data
        void GetAllWeapons();
        void GetAllWeaponsByClass();
        void GetWeapon(string weaponName);
        

        void SortWeapons();

        
        
    }
}

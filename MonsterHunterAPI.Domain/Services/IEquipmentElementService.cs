using MonsterHunterAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterAPI.Domain.Services
{
    public interface IEquipmentElementService
    {
        void AddNewEquipmentElement(string weaponName, string elementName, int elementDamage);
        void GetElementOfWeaponByWeaponId(int weaponId);
        
    }
}

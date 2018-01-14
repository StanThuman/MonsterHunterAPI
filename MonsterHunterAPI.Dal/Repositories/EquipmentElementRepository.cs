using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterHunterAPI.Dal.Models;
using MonsterHunterAPI.Domain.Repositories;

namespace MonsterHunterAPI.Dal.Repositories
{
    public class EquipmentElementRepository : IEquipmentElementRepository
    {
        MonsterHunterContext _db;


        public EquipmentElementRepository()
        {
            _db = new MonsterHunterContext();
        }

        public void AddNewEquipmentElement(int weaponId, int elementDamage)
        {

        }

        public void GetElementByWeaponId(int weaponId)
        {
            throw new NotImplementedException();
        }

    }
}

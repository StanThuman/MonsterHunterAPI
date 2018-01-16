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
    public class EquipmentElementRepository : IEquipmentElementRepository
    {
        MonsterHunterContext _db;


        public EquipmentElementRepository()
        {
            _db = new MonsterHunterContext();
        }

        public void AddNewEquipmentElement(int weaponId, ElementDTO element)
        {
            System.Diagnostics.Debug.WriteLine("insdie add new element");
            System.Diagnostics.Debug.WriteLine(element.ElementId);
            System.Diagnostics.Debug.WriteLine(element.ElementDamage);
            System.Diagnostics.Debug.WriteLine(weaponId);

            //_db.EquipmentElement.Add(new EquipmentElement()
            //{
            //    WeaponId = weaponId,
            //    ElementId = element.ElementId,
            //    ElementDamange = element.ElementDamage
            //});
        }

        public void GetElementByWeaponId(int weaponId)
        {
            throw new NotImplementedException();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterHunterAPI.Dal.Models;
using MonsterHunterAPI.Domain.Models;
using MonsterHunterAPI.Domain.Repositories;
using MonsterHunterAPI.Domain.Services;

namespace MonsterHunterAPI.Dal.Services
{
    public class EquipmentElementService : IEquipmentElementService
    {
        IEquipmentElementRepository _db;
        IElementService _elementService;

        public EquipmentElementService(IEquipmentElementRepository db, IElementService elementService)
        {
            _db = db;
            _elementService = elementService;
        }

        public void AddNewEquipmentElement(int weaponId, string elementName, int elementDamange)
        {
            Element element = null;
            _elementService.CheckElementName(elementName);
            throw new NotImplementedException();
        }

        public void GetElementOfWeaponByWeaponId(int weaponId)
        {
            throw new NotImplementedException();
        }

        
    }
}

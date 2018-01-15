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
        IEquipmentElementRepository _equipElementRepo;
        IWeaponRepository _weaponRepo;
        IElementRepository _elementRepo;
        //IElementService _elementService;

        public EquipmentElementService(IEquipmentElementRepository equipElementRepo, IWeaponRepository weaponRepo, IElementRepository elementRepo) //IElementService elementService)
        {
            _equipElementRepo = equipElementRepo;
            _weaponRepo = weaponRepo;
            _elementRepo = elementRepo;
            //_elementService = elementService;
        }

        public void AddNewEquipmentElement(string weaponName, string elementName, int elementDamange)
        {
            WeaponDTO tempWeapon = _weaponRepo.GetWeapon(weaponName);

            //find element to see if exists in element table
            _elementRepo

            _elementService.CheckElementName(elementName);
            throw new NotImplementedException();
        }

        public void GetElementOfWeaponByWeaponId(int weaponId)
        {
            throw new NotImplementedException();
        }


    }
}

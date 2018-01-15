using MonsterHunterAPI.Domain.Repositories;
using MonsterHunterAPI.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterHunterAPI.Dal.Models;
using MonsterHunterAPI.Domain.Models;


namespace MonsterHunterAPI.Dal.Services
{
    public class WeaponService : IWeaponService
    {

        IWeaponRepository _weaponRepo;
        //IEquipmentElementRepository _equipmentElementRepo;
        IEquipmentElementService _equipmentElementService;

        public WeaponService(IWeaponRepository weaponsRepo, IEquipmentElementService equipmentElementService)
        {
            _weaponRepo = weaponsRepo;
            _equipmentElementService  = equipmentElementService;
        }

        

        //start of interface implementation
        public void AddNewWeapon(WeaponDTO model)
        {
            //check is weapon has element
            //find element id
            //add new Equipment_element                 
            _weaponRepo.AddNewWeaponToDb(model);            
            _equipmentElementService.AddNewEquipmentElement(model.Name, model.Element, model.ElementDamage);

        }
        public void GetAllWeapons()
        {
            _weaponRepo.GetAllWeapons();
        }

        public void GetAllWeaponsByClass()
        {
            _weaponRepo.GetAllWeaponsByClass();
        }

        public WeaponDTO GetWeapon(string weaponName)
        {
            //check string
            return _weaponRepo.GetWeapon(weaponName);
        }
        

        public void SortWeapons()
        {
            //System.Diagnostics.Debug.WriteLine("inside weaponService: sort weapons() function");
            //_db.GetAllWeapons();
            //_db.GetAllWeaponsByClass();
            //_db.GetWeapon("something");

            
        }

      
    }
}

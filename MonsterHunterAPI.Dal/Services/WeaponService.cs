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

        IWeaponRepository _db;

        public WeaponService(IWeaponRepository weaponsRepository)
        {
            _db = weaponsRepository;
        }

        public void GetAllWeapons()
        {
            _db.GetAllWeapons();
        }

        public void GetAllWeaponsByClass()
        {
            _db.GetAllWeaponsByClass();
        }

        public void GetWeapon(string weaponName)
        {
            throw new NotImplementedException();
        }

        public void AddNewWeapon(WeaponDTO model)
        {
            //check is weapon has element
                //find element id
                //add new Equipment_element
            

            //_db.AddNewWeaponToDb(WeaponMapper(model));
        }

        

        public void SortWeapons()
        {
            System.Diagnostics.Debug.WriteLine("inside weaponService: sort weapons() function");
            _db.GetAllWeapons();
            _db.GetAllWeaponsByClass();
            _db.GetWeapon("something");

            
        }
    }
}

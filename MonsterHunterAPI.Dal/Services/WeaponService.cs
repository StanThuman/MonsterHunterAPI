﻿using MonsterHunterAPI.Domain.Repositories;
using MonsterHunterAPI.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterHunterAPI.Dal.Models;
using MonsterHunterAPI.Domain.Models;
using System.Reflection;

namespace MonsterHunterAPI.Dal.Services
{
    public class WeaponService : IWeaponService
    {

        IWeaponRepository _weaponRepo;
        IEquipmentElementRepository _equipmentElementRepo;
        IElementRepository _elementRepo;
        

        public WeaponService(IWeaponRepository weaponsRepo, IEquipmentElementRepository equipmentElementRepo, IElementRepository elementRepo)
        {
            _weaponRepo = weaponsRepo;
            _equipmentElementRepo = equipmentElementRepo;
            _elementRepo = elementRepo;
        }

        

        //start of interface implementation
        public void AddNewWeapon(WeaponDTO model)
        {
            System.Diagnostics.Debug.WriteLine("inside Add new weapon of WeaponService");
            bool hasElement = false;
            if (model.Element.ToLower() != "none")
                hasElement = true;
            //check if weapon has element
            //find element id
            //add new Equipment_element                 
            if (ValidateWeaponAttributes(model))
                    _weaponRepo.AddNewWeaponToDb(model);


            if (hasElement) {

                //int weaponId = _weaponRepo.GetWeapon(model.Name).WeaponId;
                ElementDTO equipElement = new ElementDTO();

                if (ValidateElementProperty(0, model.Element, model.ElementDamage, equipElement)) {

                    _equipmentElementRepo.AddNewEquipmentElement(0, equipElement);
                }
            }
            //check is weapon has element and if element name exists 
            //find if  element name exists in element DB
            
           // _equipmentElementRepo.AddNewEquipmentElement(model.Name, model.Element, model.ElementDamage);

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

        private bool ValidateWeaponAttributes(WeaponDTO weapon) {
            bool isValid = true;

            if (weapon.Rarity < 0 || weapon.Rarity > 6)            
                isValid = false;

            if (weapon.Slots > 3)
                isValid = false;

            System.Diagnostics.Debug.WriteLine("inside validate weapon");
            return isValid;
        }

        private bool ValidateElementProperty(int weaponId, string elementName, int elementDamage, ElementDTO newEquipElementAdd)
        {
            // add front end checking of uppertcase stirng
            bool isElementValid = false;
            IEnumerable<ElementDTO> elements = _elementRepo.GetAllElements().AsEnumerable<ElementDTO>();

            //make sure element exists in elelment db
            using (var iterator = elements.GetEnumerator()) {
                while (!isElementValid && iterator.MoveNext())
                {
                    System.Diagnostics.Debug.WriteLine("iterate elements: " + iterator.Current.Name);
                    if (elementName == iterator.Current.Name)
                    {
                        isElementValid = true;
                        newEquipElementAdd.ElementId = iterator.Current.ElementId;
                        
                        newEquipElementAdd.Name = iterator.Current.Name;

                        System.Diagnostics.Debug.WriteLine("found element");
                        System.Diagnostics.Debug.WriteLine(iterator.Current.ElementId);
                        System.Diagnostics.Debug.WriteLine(iterator.Current.ElementDamage);

                        System.Diagnostics.Debug.WriteLine('\n');

                        System.Diagnostics.Debug.WriteLine(newEquipElementAdd.ElementId);
                        System.Diagnostics.Debug.WriteLine(newEquipElementAdd.ElementDamage);
                        System.Diagnostics.Debug.WriteLine(weaponId);
                    }
                }
            }
            System.Diagnostics.Debug.WriteLine("inside validateelement");
            
            //System.Diagnostics.Debug.WriteLine(newEquipElementAdd.ElementId);
            //System.Diagnostics.Debug.WriteLine(newEquipElementAdd.ElementDamage);
            //System.Diagnostics.Debug.WriteLine(weaponId);


            return true;
        }
    }
}

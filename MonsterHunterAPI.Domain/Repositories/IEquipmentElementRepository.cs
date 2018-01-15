﻿using MonsterHunterAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterAPI.Domain.Repositories
{
    public interface IEquipmentElementRepository
    {
        void AddNewEquipmentElement(int weaponId, string elementName, int elementDamage);
        void GetElementByWeaponId(int weaponId);

    }
}

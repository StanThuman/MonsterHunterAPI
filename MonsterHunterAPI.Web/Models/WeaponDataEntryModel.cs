using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterHunterAPI.Web.Models
{
    public class WeaponDataEntryModel
    {        
        public string Name { get; set; }
        public int Rarity { get; set; }
        public int Attack { get; set; }
        public string Element { get; set; }
        public string Sharpness { get; set; }
        public int Slots { get; set; }
        public int Affinity { get; set; }
        public int Defense { get; set; }

    }
}
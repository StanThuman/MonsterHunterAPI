using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterHunterAPI.Domain.Models
{
    public class WeaponDTO
    {        
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Rarity { get; set; }
        public string Element { get; set; }
        public string Sharpness { get; set; }
        public int Slots { get; set; }
        public int Affinity { get; set; }
        public int Defense { get; set; }

        //public virtual ICollection<EquipmentElement> Elements { get; set; }
    }
}


using System.Collections.Generic;

namespace MonsterHunterAPI.Dal.Models
{
    public class EquipmentElement
    {        
        public int EquipmentElementId { get; set; }
        public int WeaponId { get; set; }
        public int ElementId { get; set; }
        public int ElementDamange { get; set; }

        public virtual ICollection<Weapon> Weapon { get; set; }
        public virtual Element Element { get; set; }
        
    }
}

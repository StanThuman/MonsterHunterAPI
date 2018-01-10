
using System.Collections.Generic;

namespace MonsterHunterAPI.Dal.Models
{
    public class Element
    {
        
        public int ElementId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<EquipmentElement> EquipmentElements { get; set; }
        
    }
}

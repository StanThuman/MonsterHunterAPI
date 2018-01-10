using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterHunterAPI.Dal.Models;
using MonsterHunterAPI.Domain.Services;
using MonsterHunterAPI.Domain.Models;

namespace MonsterHunterAPI.Dal.Services
{
    public class ElementService : IElementService
    {
        private MonsterHunterContext _db;
        
        public ElementService()
        {
            _db = new MonsterHunterContext();
        }

        public void AddNewElement(ElementDTO model)
        {
            Element newElement = ElementMapper(model);
            System.Diagnostics.Debug.WriteLine("inside new element service");
            System.Diagnostics.Debug.WriteLine(newElement.Name);
            //_db.Elements.Add(newElement);
        }


        private Element ElementMapper(ElementDTO model)
        {
            return new Element()
            {
                Name = model.Name
                

            };

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterHunterAPI.Dal.Models;
using MonsterHunterAPI.Domain.Models;
using MonsterHunterAPI.Domain.Repositories;

namespace MonsterHunterAPI.Dal.Repositories
{
    public class ElementRepository : IElementRepository
    {
        MonsterHunterContext _db;
        public ElementRepository()
        {
            _db = new MonsterHunterContext();
        }

        public void AddNewElement(ElementDTO model)
        {
            if(model != null && model.Name != "")
            {
                
                GetAllElements().Where(x => x.Name == model.Name);

                
            }

            _db.Elements.Add(ElementMapper(model));

       
        }

        public int GetElementId(string elementName)
        {
            return 1;
        }

        public IEnumerable<ElementDTO> GetAllElements()
        {
            return ElementDTOMapper(_db.Elements.AsEnumerable<Element>());
        }

        private Element ElementMapper(ElementDTO model)
        {
            return new Element()
            {
                ElementId = model.ElementId,
                Name = model.Name

            };

        }

        private IEnumerable<ElementDTO> ElementDTOMapper(IEnumerable<Element> modelList)
        {
            List<ElementDTO> newList = new List<ElementDTO>();

            ElementDTO tempElement;
            foreach(Element ele in modelList)
            {
                tempElement = new ElementDTO()
                {
                    ElementId = ele.ElementId,
                    Name = ele.Name
                };                
                
                newList.Add(tempElement);
            }

            return newList.AsEnumerable<ElementDTO>();
        }



    }
}

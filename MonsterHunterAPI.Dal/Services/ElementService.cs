using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterHunterAPI.Dal.Models;
using MonsterHunterAPI.Domain.Services;
using MonsterHunterAPI.Domain.Models;
using MonsterHunterAPI.Domain.Repositories;

namespace MonsterHunterAPI.Dal.Services
{
    public class ElementService : IElementService
    {
        private IElementRepository _elementRepository;
        
        public ElementService(IElementRepository db)
        {
            _elementRepository = db;
        }

        public void AddNewElement(ElementDTO model)
        {           
            _elementRepository.AddNewElement(model);
        }

        public IEnumerable<ElementDTO> GetAllElements()
        {
            return _elementRepository.GetAllElements();
        }

        
    }
}

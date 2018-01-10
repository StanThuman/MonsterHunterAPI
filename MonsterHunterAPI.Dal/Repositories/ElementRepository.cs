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

        public void AddNewElement(ElementDTO element)
        {

            //TODO _db.Elements.Add(element)
        }
    }
}

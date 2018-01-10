using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterHunterAPI.Domain.Models;

namespace MonsterHunterAPI.Domain.Repositories
{
    public interface IElementRepository
    {
        void AddNewElement(ElementDTO element);
    }
}

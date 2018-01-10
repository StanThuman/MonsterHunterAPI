using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterHunterAPI.Domain.Models;

namespace MonsterHunterAPI.Domain.Services
{
    public interface IElementService
    {
        void AddNewElement(ElementDTO model);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonsterHunterAPI.Domain.Services;

namespace MonsterHunterAPI.Web.Services
{
    public class ElementService
    {
        IElementService _service;

        public ElementService(IElementService service)
        {
            _service = service;
        }
    }
}
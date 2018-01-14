using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonsterHunterAPI.Domain.Models;
using MonsterHunterAPI.Domain.Services;
using MonsterHunterAPI.Web.Models;


namespace MonsterHunterAPI.Web.Services
{
    public class ElementService
    {
        IElementService _service;

        public ElementService(IElementService service)
        {
            _service = service;
        }

        public void AddNewElementToDb(ElementDataEntryModel model)
        {
            _service.AddNewElement(ElementMapper(model));
        }


        private ElementDTO ElementMapper(ElementDataEntryModel model)
        {
            return new ElementDTO()
            {
                Name = model.Name
            };
        }
    }
}
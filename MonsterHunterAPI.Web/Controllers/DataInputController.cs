using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonsterHunterAPI.Domain.Services;
using MonsterHunterAPI.Web.Models;
using MonsterHunterAPI.Web.Services;

namespace MonsterHunterAPI.Web.Controllers
{
    public class DataInputController : Controller
    {
        WeaponService _service;
        
        public DataInputController(IWeaponService service)
        {
            this._service = new WeaponService(service);
            
        }
        // GET: DataInput
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(WeaponDataEntryModel model)
        {
            WeaponDataEntryModel testObject = new WeaponDataEntryModel()
            {
                Name = "test sword",
                Rarity = 3,
                Attack = 234,
                Affinity = 32,
                Slots = 3
            };

            
            _service.AddWeaponToDb(testObject);
            return Redirect("/DataInput");
        }


    }
}
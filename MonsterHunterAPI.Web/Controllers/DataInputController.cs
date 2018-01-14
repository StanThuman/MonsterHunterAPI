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
        WeaponService _weaponService;
        

        public DataInputController(IWeaponService weaponService)
        {
            this._weaponService = new WeaponService(weaponService);
            
            
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
                Element = "water",
                ElementDamange = 343,
                Affinity = 32,
                Slots = 3
            };

            
            _weaponService.AddWeaponToDb(testObject);
            return Redirect("/DataInput");
        }


    }
}
using MonsterHunterAPI.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MonsterHunterAPI.Web.Controllers
{
    public class WeaponsController : ApiController
    {
        IWeaponService _weaponsService;

        public WeaponsController(IWeaponService weaponsService)
        {
            _weaponsService = weaponsService;
        }

        public string Get()
        {
            _weaponsService.GetAllWeapons();
            return "all weapons";
        }

        public string Get(int id)
        {
            return "id";
        }
    }
}

using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonsterHunterAPI.Web;
using MonsterHunterAPI.Web.Controllers;
using MonsterHunterAPI.Dal.Services;
using MonsterHunterAPI.Dal.Repositories;
using MonsterHunterAPI.Domain.Services;
using MonsterHunterAPI.Web.Models;
using System.Linq;

namespace MonsterHunterAPI.Web.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {

        
        IElementService _element;
        //MonsterHunterContext db;
        Services.WeaponService weaponService;

        [TestMethod]
        public void Index()
        {

            //_weapons = new WeaponService(new WeaponRepository());

            //Assert.IsNotNull(_weapons);
            weaponService = new Services.WeaponService(new MonsterHunterAPI.Dal.Services.WeaponService(new WeaponRepository(), new EquipmentElementRepository(), new ElementRepository()));

            WeaponDataEntryModel testObject = new WeaponDataEntryModel()
            {
                Name = "test sword",
                Rarity = 3,
                Element = "Water",
                ElementDamange = 384,
                Sharpness = "white/green",
                Attack = 234,
                Affinity = 35,
                Slots = 3
            };

            weaponService.AddWeaponToDb(testObject);


            // Arrange
            //HomeController controller = new HomeController();

            // Act
            //ViewResult result = controller.Index() as ViewResult;

            // Assert
            //Assert.IsNotNull(result);
            //Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}

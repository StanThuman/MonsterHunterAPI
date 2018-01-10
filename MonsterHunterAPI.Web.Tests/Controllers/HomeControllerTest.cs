using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonsterHunterAPI.Web;
using MonsterHunterAPI.Web.Controllers;
using MonsterHunterAPI.Domain.Services;
using MonsterHunterAPI.Dal.Services;
using MonsterHunterAPI.Dal.Repositories;

namespace MonsterHunterAPI.Web.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {

        IWeaponService _weapons;

        
        

        [TestMethod]
        public void Index()
        {

            _weapons = new WeaponService(new WeaponRepository());

            Assert.IsNotNull(_weapons);
            _weapons.GetAllWeaponsByClass();
            System.Diagnostics.Debug.WriteLine("LDJFLJDLKFJ");
        
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

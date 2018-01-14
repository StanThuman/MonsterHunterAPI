using MonsterHunterAPI.Dal.Repositories;
using MonsterHunterAPI.Dal.Services;
using MonsterHunterAPI.Domain.Repositories;
using MonsterHunterAPI.Domain.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Unity;
using Unity.Exceptions;


namespace MonsterHunterAPI.IoC
{
    public class UnityResolver
    {
        

        
        public static void RegisterServices(UnityContainer container)
        {
            container.RegisterType<IWeaponRepository, WeaponRepository>();
            container.RegisterType<IWeaponService, WeaponService>();
            container.RegisterType<IElementRepository, ElementRepository>();
            container.RegisterType<IElementService, ElementService>();
            

        }

        //public static void RegisterComponents()
        //{
        //    var container = new UnityContainer();

        //    container.RegisterType<IWeaponsRepository, WeaponsRepository>();
        //    container.RegisterType<IWeaponsService, WeaponsService>();

        //    // register all your components with the container here
        //    // it is NOT necessary to register your controllers

        //    // e.g. container.RegisterType<ITestService, TestService>();
        //    UnityResolver.RegisterServices(container);            
            
        //}



    }
}


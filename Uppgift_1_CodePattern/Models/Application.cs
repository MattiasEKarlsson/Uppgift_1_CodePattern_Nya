﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.DailyServices;
using Uppgift_1_CodePattern.Models.InitLists;

namespace Uppgift_1_CodePattern.Models
{
    internal class Application : IApplication
    {
        IMainMenu _mainMenu;
        public Application(IMainMenu mainMenu)
        {
            _mainMenu = mainMenu;
        }

        List<ICustomer> customers;
        List<IPet> pets;
        List<IExtras> extras;

        public void Run()
        {
            customers = CreateCustomerList.CreateCustomers();
            pets = CreatePetList.CreatePets(customers);
            extras = CreateExtrasList.CreateExtras();
            _mainMenu.CreateMenu(customers, pets, extras);

            
        }
    }
}

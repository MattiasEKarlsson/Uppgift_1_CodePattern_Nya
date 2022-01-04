﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.CustomerManagment;
using Uppgift_1_CodePattern.Interfaces.DailyServices;

using Uppgift_1_CodePattern.Interfaces.Mangment;
using Uppgift_1_CodePattern.Interfaces.PetMangment;
using Uppgift_1_CodePattern.Interfaces.Tools;
using Uppgift_1_CodePattern.Models;
using Uppgift_1_CodePattern.Models.Customers;
using Uppgift_1_CodePattern.Models.DailyManagment;
using Uppgift_1_CodePattern.Models.DailyServices;
using Uppgift_1_CodePattern.Models.Managment;
using Uppgift_1_CodePattern.Models.Pets;
using Uppgift_1_CodePattern.Models.Tools;

namespace Uppgift_1_CodePattern
{
    internal class AFConfig
    {
        public static IContainer Configure()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<ConsoleMenu>().As<IMainMenu>();

            
            builder.RegisterType<Owner>().As<ICustomer>();
            builder.RegisterType<CreateOwnerFactory>().As<ICreateCustomer>();
            builder.RegisterType<Owner>();
            
            builder.RegisterType<CreateDogFactory>().As<ICreatePet>();
            builder.RegisterType<Pet>().As<IPet>();
            builder.RegisterType<Pet>();

            builder.RegisterType<SeeAllOwners>().As<IPrintCustomerInfo>();
            builder.RegisterType<SeeCheckedInPets>().As<ISeeCheckedInPets>();
            builder.RegisterType<SeeAllPets>().As<IPrintAllPets>();
            builder.RegisterType<CheckInAndOutPet>().As<ICheckInAndOutPet>();
            builder.RegisterType<CalculateBill_Dog>().As<ICalcBill>();
            builder.RegisterType<ClearAndConfirmTools>().As<ITools>();

            builder.RegisterType<Validate>().As<IValidations>();
            builder.RegisterType<AskForInput>().As<IAskForInput>();


            builder.RegisterType<Extras>().As<IExtras>();
            builder.RegisterType<LinkExtrasToPet>().As<ILinkExtrasToPet>();







            return builder.Build();
        }
    }
}

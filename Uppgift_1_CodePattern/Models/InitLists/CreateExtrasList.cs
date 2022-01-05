using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces.DailyServices;
using Uppgift_1_CodePattern.Models.DailyServices;

namespace Uppgift_1_CodePattern.Models.InitLists
{
    public  class CreateExtrasList
    {
        public static List<IExtras> CreateExtras()
        {
            List<IExtras> extras = new List<IExtras>
            {
                new Extras{Id = 1, Name = "Wash", Price = 150},
                new Extras{Id = 2, Name = "Claw Trimming", Price = 200 },
                new Extras{Id = 3, Name = "BastuBad", Price = 200 }
            };
            return extras;
        }
    }
}

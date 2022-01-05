using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.DailyServices;
using Uppgift_1_CodePattern.Interfaces.Tools;

namespace Uppgift_1_CodePattern.Models.DailyManagment
{
    internal class CalculateBill_Dog : ICalcBill
    {
        ITools _tools;

        public CalculateBill_Dog(ITools tools)
        {
            _tools = tools;
        }

        public void CalcTotal(IPet pet)
        {
            int total = StaticDetails.PricePerAnimal;
            if (pet.Extras != null)
            {
                foreach (var extra in pet.Extras)
                {
                    total = total + extra.Price;
                    Console.WriteLine($"{extra.Name}: {extra.Price}KR");
                }
                pet.Extras.Clear();
            }

            Console.WriteLine($"Daily stay: {StaticDetails.PricePerAnimal} kr");
           
            Console.WriteLine($"---Total:{total}---");
        }
    }
}

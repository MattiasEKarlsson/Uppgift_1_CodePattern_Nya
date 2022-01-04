using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.DailyServices;

namespace Uppgift_1_CodePattern.Models.DailyServices
{
    public class LinkExtrasToPet : ILinkExtrasToPet
    {
        public void LinkExtra(List<IPet> pets, List<IExtras> extras)
        {
            Console.WriteLine("dsf");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces.DailyServices;

namespace Uppgift_1_CodePattern.Models.DailyServices
{
    internal class Extras : IExtras
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}

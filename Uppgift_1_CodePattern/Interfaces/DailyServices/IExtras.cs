using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1_CodePattern.Interfaces.DailyServices
{
    public interface IExtras
    {
        int Id { get; set; }
        string Name { get; set; }
        int Price { get; set; }
    }
}

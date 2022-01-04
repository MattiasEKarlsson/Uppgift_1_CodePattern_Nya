using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces.DailyServices;

namespace Uppgift_1_CodePattern.Interfaces
{
    public interface IPet 
    {
        
        string Name { get; set; }
        ICustomer Owner { get; set; }
        bool AtKennel { get; set; }
        List<IExtras> Extras { get; set; }
    }
}

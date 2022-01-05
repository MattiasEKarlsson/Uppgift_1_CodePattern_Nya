using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Models.DailyServices;

namespace Uppgift_1_CodePattern.Interfaces.DailyServices
{
    public interface ILinkExtrasToPet
    {
        IPet GetPetInput(List<IPet> pets);
        IExtras GetExtraInput(List<IExtras> extras);

    }
}

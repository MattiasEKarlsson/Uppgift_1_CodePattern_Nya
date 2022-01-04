using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1_CodePattern.Interfaces.DailyServices
{
    public interface ILinkExtrasToPet
    {
        void LinkExtra(List<IPet> pets, List<IExtras> extras);
    }
}

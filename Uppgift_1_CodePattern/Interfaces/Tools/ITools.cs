using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1_CodePattern.Interfaces.Tools
{
    public interface ITools
    {
        void ConfirmAndClearConsol(string message);
        void ErrorMessageConsol(string message);

        void WaitForKeyPress();
    }
}

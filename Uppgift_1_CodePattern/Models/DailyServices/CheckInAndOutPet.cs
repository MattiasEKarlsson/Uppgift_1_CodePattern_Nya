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
    internal class CheckInAndOutPet : ICheckInAndOutPet
    {
        private readonly IPet _pet;
        private readonly ICalcBill _calcBill;
        private readonly ITools _tools;
        private readonly IAskForInput _askForInput;

        public CheckInAndOutPet(IPet pet, ICalcBill calcBill, ITools tools, IAskForInput askForInput)
        {
            _pet = pet;
            _calcBill = calcBill;
            _tools = tools;
            _askForInput = askForInput;
        }

        public void CheckInPet(List<IPet> pets)
        {
            Console.WriteLine("Checkin");
            string inputName = _askForInput.AskForInput("pets name:", 3);
            IPet pet = pets.FirstOrDefault(name => name.Name.ToLower() == inputName.ToLower());

                
                Console.Clear();

                if (pet != null && pet.AtKennel == false)
                {
                     pet.AtKennel = true;
                    
                     _tools.ConfirmAndClearConsol($"Checked in {pet.Name}");
                
                }
                else
                {
                    _tools.ErrorMessageConsol("Not found or already here.");
                }
            


        }

        public void CheckOutPet(List<IPet> pets)
        {
            Console.WriteLine("Checkout");
            string inputName = _askForInput.AskForInput("pets name:", 3);
            Console.Clear();
                IPet pet = pets.FirstOrDefault(name => name.Name.ToLower() == inputName.ToLower());
                
                if (pet != null && pet.AtKennel == true)
                {
                    pet.AtKennel = false;
                    _calcBill.CalcTotal(pet);
                    _tools.ConfirmAndClearConsol($"Checked out {pet.Name}");
                }
                else
                {
                _tools.ErrorMessageConsol("Not Found");
                }
        }
    }
}

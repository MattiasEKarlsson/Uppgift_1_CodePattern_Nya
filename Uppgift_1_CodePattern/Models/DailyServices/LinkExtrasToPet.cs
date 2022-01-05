using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.DailyServices;
using Uppgift_1_CodePattern.Interfaces.Tools;

namespace Uppgift_1_CodePattern.Models.DailyServices
{
    public class LinkExtrasToPet : ILinkExtrasToPet
    {
        private readonly IAskForInput _askForInput;
        private readonly ITools _tools;

        public LinkExtrasToPet(IAskForInput askForInput, ITools tools)
        {
            _askForInput = askForInput;
            _tools = tools;
        }

        public IPet GetPetInput(List<IPet> pets)
        {
            Console.WriteLine("Add Extra To Pet");
            string inputName = _askForInput.AskForInput("Enter pets name:", 3);
            IPet pet = pets.FirstOrDefault(name => name.Name.ToLower() == inputName.ToLower());
            if (pet != null && pet.AtKennel)
            {
                return pet;
            }
            else
            {
                _tools.ErrorMessageConsol("Pets not here");
                return null;
            }
        }
        public IExtras GetExtraInput(List<IExtras> extras)
        {
            foreach (var extra in extras)
            {
                Console.WriteLine($"[{extra.Id}]---{extra.Name}---{extra.Price}KR");
            }
            int inputExtra;

            if (int.TryParse(Console.ReadLine(), out inputExtra))
            {
                if (inputExtra <= extras.Count + 1)
                {
                    inputExtra = inputExtra - 1;

                    _tools.ConfirmAndClearConsol($"Added {extras[inputExtra].Name}");
                    return extras[inputExtra];
                }
                return null;
            }
            _tools.ConfirmAndClearConsol($"Wrong input!");
            return null;
            
        }
    }
}

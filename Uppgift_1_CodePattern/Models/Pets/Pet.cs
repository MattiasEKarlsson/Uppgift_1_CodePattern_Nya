using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Interfaces.DailyServices;

namespace Uppgift_1_CodePattern.Models.Pets
{
    internal class Pet : IPet
    {
        public Pet(string name, ICustomer owner, bool atKennel)
        {
            this.Name = name;
            this.Owner = owner;
            this.AtKennel = atKennel;
            
        }

        public Pet()
        {

        }
        public delegate Pet Factory(string name, ICustomer owner, bool atKennel);

        
        public string Name { get; set; }
        public ICustomer Owner { get; set; }
        public bool AtKennel { get; set; }
        public List<IExtras> Extras { get; set; }
    }
}

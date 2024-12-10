using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_1210
{
    class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int AgeInYears { get; set; }
        public string OwnerPersonalId { get; set; }
        public string ChipNumber { get; set; } //not nullnak kell lennie amire nem jöttem rá

        public Pet(string name, string species, int ageInYears, string ownerPersonalId, string chipNumber)
        {
            this.Name = name;
            this.Species = species;
            this.AgeInYears = ageInYears;
            this.OwnerPersonalId = ownerPersonalId;
            this.ChipNumber = chipNumber;
        }

        public override string ToString()
        {
            string info;

            info = $"Ezen háziállat neve {this.Name}, faja {this.Species}, kora (években) pedig {this.AgeInYears}.\n";
            info += $"Gazdájának személyi száma {this.OwnerPersonalId}, saját chipszáma {this.ChipNumber}.";
            
            return info;
        }
    }
}

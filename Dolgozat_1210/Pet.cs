using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public Pet(string chipNumber)
        {
            this.ChipNumber = chipNumber;
        }

        public Pet(string name, string chipNumber)
        {
            this.Name=name;
            this.ChipNumber = chipNumber;
        }

        public Pet(string name, string ownerPersonalId, string chipNumber)
        {
            this.Name = name;
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

        public string IsTreatedByWho(VetClinic clinic)
        {
            string result;
            
            foreach (Vet vet in clinic.ListOfVets)
            {
                foreach (Pet pet in vet.PatientList)
                {
                    if (pet == this)
                    {
                        result = $"Ez a háziállat ({this.Name}) kezelve van a klinikán ({clinic.ClinicName}), méghozzá {vet.Name} által.";
                        return result;
                    }
                }
            }

            result = $"Ez a háziállat ({this.Name}) nincs kezelve ezen a klinikán ({clinic.ClinicName}).";
            return result;
        }

        public override int GetHashCode()
        {
            return ChipNumber.GetHashCode();
        }
    }
}
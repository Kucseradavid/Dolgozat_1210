using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_1210
{
    class VetClinic : IComparable
    {
        public string ClinicName { get; set; }
        public string ClinicAddress { get; set; }
        public string ClinicPhone { get; set; }
        public string ClinicEmail { get; set; }
        public HashSet<Vet> ListOfVets { get; set; }

        public VetClinic(string clinicName, string clinicAddress, string clinicPhone, string clinicEmail, HashSet<Vet> listOfVets)
        {
            this.ClinicName = clinicName;
            this.ClinicAddress = clinicAddress;
            this.ClinicPhone = clinicPhone;
            this.ClinicEmail = clinicEmail;
            this.ListOfVets = listOfVets;
        }

        public override string ToString()
        {
            string info;

            info = $"A klinika neve {this.ClinicName}.\n";
            info += $"Elérhetőségei:\n\tCím: {this.ClinicAddress}\n\tEmail-cím: {this.ClinicEmail}\n\tTelefonszám: {this.ClinicPhone}\n";
            info += "Az itt dolgozó állatorvosok:\n";
            foreach (Vet vet in ListOfVets) { info += "\t" + vet.Name + "\n"; }
            info = info.TrimEnd();
            
            return info;
        }

        public int CompareTo(object objektum)
        {
            VetClinic klinika = objektum as VetClinic;

            return this.ListOfVets.Count.CompareTo(klinika.ListOfVets.Count);
        }
    }
}

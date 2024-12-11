using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_1210
{
    class Vet : Person
    {
        public string CertificateNumber { get; set; }
        public string[] TreatedSpecies { get; set; }
        public HashSet<Pet> PatientList { get; set; }

        public Vet(string personalId, string name, string phoneNumber, string emailAddress, string certificateNumber, string[] treatedSpecies, HashSet<Pet> patientList)
        {
            this.PersonalId = personalId;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
            this.CertificateNumber = certificateNumber;
            this.TreatedSpecies = treatedSpecies;
            this.PatientList = patientList;
        }

        public Vet(string personalId, string name, string phoneNumber, string emailAddress, string certificateNumber, string[] treatedSpecies, HashSet<Owner> ownerList)
        {
            this.PersonalId = personalId;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
            this.CertificateNumber = certificateNumber;
            this.TreatedSpecies = treatedSpecies;
            this.PatientList = FillPatientList(ownerList);
        }

        public override string ToString()
        {
            string info;

            info = $"Eme állatorvos neve {this.Name}, személyszáma {this.PersonalId}.\n";
            info += $"Elérhetőségei:\n\tEmail-cím: {this.EmailAddress}\n\tTelefonszám: {this.PhoneNumber}\n";
            info += $"Bizonyítványszáma {this.CertificateNumber}.";
            info += " Általa kezelt állatfajok:\n\t";
            foreach (string species in this.TreatedSpecies) { info += species + ", "; }
            info = info.TrimEnd();
            info += "\nÁltala kezelt háziállatok:\n";
            foreach (Pet patient in this.PatientList) { info += "\t" + patient.Name + "\n"; }
            info = info.TrimEnd();

            return info;
        }

        public HashSet<Pet> FillPatientList(HashSet<Owner> owners)
        {
            HashSet<Pet> newPatientList = new HashSet<Pet>();

            foreach (string species in this.TreatedSpecies)
            {
                foreach (Owner owner in owners)
                {
                    foreach (Pet pet in owner.GuardedPets)
                    {
                        if (pet.Species == species)
                        {
                            newPatientList.Add(pet);
                        }
                    }
                }
            }
            
            return newPatientList;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Vet)) return false;

            return this.PersonalId == ((Vet)obj).PersonalId;
        }

        public override int GetHashCode()
        {
            return PersonalId.GetHashCode();
        }
    }
}

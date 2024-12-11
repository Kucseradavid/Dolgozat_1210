using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_1210
{
    class Owner : Person
    {
        public string BillingAddress { get; set; }
        public HashSet<Pet> GuardedPets { get; set; }

        public Owner(string personalId, string name, string phoneNumber, string emailAddress, string billingAddress, HashSet<Pet> guardedPets)
        {
            this.PersonalId = personalId;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
            this.BillingAddress = billingAddress;
            this.GuardedPets = guardedPets;
        }

        public override string ToString()
        {
            string info;

            info = $"E személy neve {this.Name}, személyszáma {this.PersonalId}.\n";
            info += $"Elérhetőségei:\n\tEmail-cím: {this.EmailAddress}\n\tTelefonszám: {this.PhoneNumber}\n\tSzámlázási cím: {this.BillingAddress}\n";
            info += "Általa tartott háziállatok:\n";
            foreach (Pet p in this.GuardedPets) { info += "\t" + p.Name + "\n"; }
            info = info.TrimEnd();

            return info;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Owner)) return false;

            return this.PersonalId == ((Owner)obj).PersonalId;
        }

        public override int GetHashCode()
        {
            return PersonalId.GetHashCode();
        }
    }
}

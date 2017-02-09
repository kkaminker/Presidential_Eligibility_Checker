using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class EligibilityChecker
    {
        private Boolean eligible;

        public EligibilityChecker(int age, Boolean bornInUs, int yearsResident, int timesElected, Boolean convicted)
        {
            if (age >= 35 && bornInUs && yearsResident >= 14 && timesElected < 2 && !convicted)
            {
                this.eligible = true;
            }
            else
                this.eligible = false;

           
        }

        public Boolean isEligible()
        {
            return this.eligible;
        }
     



    }
}

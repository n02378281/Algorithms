using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.DesignPatterns.SOLID_Principles
{
    class OpenClosedPrinciple
    {
        public enum AccType
        {
            Regular = 0,
            Salary = 1,
            Corporate = 2
        }
        public decimal CalcInt(AccType accType)
        {
            double bal = 1000;
            double amt = 1000;
            double inte = bal * 0.4;
            if (AccType.Regular.ToString() == "Regular")// savings
            {
                if (bal < 1000)
                {
                    inte -= bal * 0.2;
                }
                if (bal < 50000) inte += amt * 0.4;
            }
            else if (AccType.Salary.ToString() == "Salary")// salary savings

            {
                inte = bal * 0.5;
            }
            else if (AccType.Corporate.ToString() == "Corporate")// Corporate
            {
                inte = bal * 0.3;
            }
            return (decimal)inte;
        }

    }
}

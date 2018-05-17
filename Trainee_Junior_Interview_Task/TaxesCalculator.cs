using System;

namespace Trainee_Junior_Interview_Task
{
    class TaxesCalculator
    {
   
        public TaxesCalculator()
        {
        }

        public double Calculate(double basicSalary,double currentSalary)
        {
            if (basicSalary <= 0 || currentSalary <= 0)
            {
                throw new Exception("Incorrect data");
            }

            double taxes = 0;
            if (currentSalary <= basicSalary)
            {
                return taxes;
            }
            if (currentSalary > basicSalary && basicSalary <= 5 * basicSalary)
            {
                taxes = currentSalary * 15 / 100;
                return taxes;
            }
            if (currentSalary > 5 * basicSalary && 5 * basicSalary <= 10 * basicSalary)
            {
                taxes = (currentSalary - 5 * basicSalary) * 17 / 100;
                return taxes;
            }
            if (currentSalary > 10 * basicSalary)
            {
                taxes = (currentSalary - 5 * basicSalary) * 20 / 100;
                return taxes;
            }
            return taxes;
        }

    }
}

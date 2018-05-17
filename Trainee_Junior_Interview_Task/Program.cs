using System;

namespace Trainee_Junior_Interview_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter Basic Salary");
                double basicSalary = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter Current Salary");
                double currentSalary = double.Parse(Console.ReadLine());

                TaxesCalculator taxesCalculator = new TaxesCalculator();

                var taxes = taxesCalculator.Calculate(basicSalary, currentSalary);
                var currentSalaryNetto = currentSalary - taxes;
                Console.WriteLine($"Basic Salary: {basicSalary}");
                Console.WriteLine($"Current Salary (Bruto): {currentSalary}");
                Console.WriteLine($"Taxes to pay: {taxes}");
                Console.WriteLine($"Current Salary (Netto): {currentSalaryNetto}");

                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }
    }
}

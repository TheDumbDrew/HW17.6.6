using HW17._6._6;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17._6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = new RenderedСlass();

            result.DistributionMethod(new SalaryBankAccount());

            Console.WriteLine();

            result.DistributionMethod(new SimpleBankAccount());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW17._6._6
{
    public class RenderedСlass
    {
        public void DistributionMethod(ICalculator calculator)
        {
            // Выношу бизнесс логику из класса Calculator и заменяю его на класс RenderedСlass, чтобы не путаться
            calculator.CalculateInterest();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RangeExceptions
{
    class MainProgram
    {
        static void Main()
        {
            int numberInput = 2;
            int startInt = 1;
            int endInt = 100;
            if (numberInput < startInt || numberInput > endInt)
            {
                throw new InvalidRangeException<int>(string.Format(InvalidRangeException<int>.InvalidValueInRangeFormat, startInt, endInt));
            }
            else Console.WriteLine(numberInput);

            DateTime dateInput = new DateTime(1890, 1, 1);
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);
            if (dateInput <  startDate || dateInput > endDate)
            {
                throw new InvalidRangeException<DateTime>(string.Format(InvalidRangeException<DateTime>.InvalidValueInRangeFormat
                    ,startDate, endDate));
            }
            else Console.WriteLine(dateInput);
        }
    }
}

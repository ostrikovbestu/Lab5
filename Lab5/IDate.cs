using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    /**
     * Определим интерфейс для свойств и метода.
     */
    interface IDate
    {
        int Hour { get; set; }
        int Minute { get; set; }
        int Day { get; set; }
        int Year { get; set; }
        string Month { get; set; }

        void PrintDate();
    }
}

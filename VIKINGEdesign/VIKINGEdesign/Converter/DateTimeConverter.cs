using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIKINGEdesign.Converter
{
    class DateTimeConverter
    {
        public static DateTime DateTimeOffset(DateTimeOffset date)
        {
            //Retunere en rigtig datetime.
            return new DateTime(date.Year, date.Month, date.Day);
        }
    }
}

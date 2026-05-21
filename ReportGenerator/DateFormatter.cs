using System;
using System.Collections.Generic;
using System.Text;

namespace ReportGenerator
{
    internal class DateFormatter : IDateFormatter
    {
        public string FormatDate(string input)
        {
            if (DateTime.TryParse(input, out DateTime date))
            {
                return date.ToString("dd/MM/yyyy HH:mm:ss");
            }
            return input;
        }
    }
}

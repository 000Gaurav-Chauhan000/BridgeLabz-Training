using System;
using System.Globalization;

namespace MyApp
{
    public class DateFormatter
    {
        public string FormatDate(string inputDate)
        {
            if (string.IsNullOrEmpty(inputDate))
                return null;

            DateTime dt;
            bool success = DateTime.TryParseExact(
                inputDate,
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out dt
            );

            if (!success)
                return null;

            return dt.ToString("dd-MM-yyyy");
        }
    }
}

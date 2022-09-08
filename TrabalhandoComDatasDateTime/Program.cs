using System;

namespace TrabalhandoComDatasDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            var today = DateTime.Today;

            var threeDaysAgo = today.AddDays(-3);
            //var threeDaysAgo = now.AddDays(-3);
            var sixMonthsLater = today.AddMonths(6);
            var twoYearsLater = today.AddYears(2);

            var shortDate = now.ToShortDateString();
            var longDate = now.ToLongDateString();

            Console.ReadKey();
        }
    }
}

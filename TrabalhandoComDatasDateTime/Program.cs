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

            var date = now.Date;
            var day = now.Day;
            var month = now.Month;
            var year = now.Year;
            var hour = now.Hour;
            var minute = now.Minute;
            var second = now.Second;

            var dayOfWeek = now.DayOfWeek;

            if(dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("É fim de semana");
            }

            var dayOfYear = now.DayOfYear;
            Console.ReadKey();
        }
    }
}

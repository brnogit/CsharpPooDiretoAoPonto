using System;

namespace TrabalhandoComDatasFormatacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            #region DateTime Formatação
            Console.WriteLine("Formatos: ");

            var formats = new string[] { "d", "D", "f", "F", "g", "G", "m", "o", "r", "s", "t", "u", "U", "Y" };

            foreach (var format in formats)
            {
                Console.WriteLine("Data no Formato {0}: {1}", format, now.ToString(format));
                //Console.WriteLine($"Data no formato {format}: {now.ToString(format)}");
            }
            Console.WriteLine("Diferentes maneiras de formatar manualmente.");
            Console.WriteLine($"Data no Formato d: {now:d}");
            Console.WriteLine($"Data no Formato MM-dd-yyyy: {now:MM-dd-yyyy}");
            var dateFormat = now.ToString("MM-dd-yyyy");
            var dateFormatBr = now.ToString("dd/MM/yyyy HH:mm:ss");

            #endregion

            Console.ReadKey();
        }
    }
}

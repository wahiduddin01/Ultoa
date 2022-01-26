using System;
namespace UltoaDecimalConverter
{
    public class UI
    {
        public long decimalNum;
        public DecimalConverter decimalConverter;

        public UI()
        {
            decimalConverter = new DecimalConverter();
        }

        public void Run()
        {
            Console.WriteLine("Enter a decimal number to convert it from bases 2 to 16");

            string decimalNumberUsr = Console.ReadLine();
            decimalNumberUsr = decimalNumberUsr.Trim();

            Boolean isNumeric = long.TryParse(decimalNumberUsr, out decimalNum);
            if (isNumeric == false)
            {
                Console.WriteLine("Invalid entry");
                Run();
            }
            else
            {
                string result = string.Empty;
                for (int i = 2; i < 17; i++)
                {
                    result = decimalConverter.ConvertDecimal(i, decimalNum);
                    Console.WriteLine("Base " + i + ": " + result);
                }
                Run();
            }
        }
    }
}


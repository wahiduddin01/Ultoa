using System;
namespace UltoaDecimalConverter
{
    public class DecimalConverter
    {
        public DecimalConverter()
        {
        }

        public char getValue(int remainder)
        {
            if ((remainder >= 0) && (remainder <= 9))
            {
                return (char)('0' + remainder);
            }
            else
            {
                return (char)(remainder - 10 + 'A');
            }
        }

        public string ConvertDecimal(int radix, long decimalNum)
        {
            string output = "";

            while (decimalNum > 0)
            {
                output += getValue((int)(decimalNum % radix));
                decimalNum = decimalNum / radix;
            }

            output = ReverseString(output);
            return output;

        }

        public string ReverseString(string word)
        {
            char[] outputArray = word.ToCharArray();
            Array.Reverse(outputArray);
            return new string(outputArray);
        }
    }
}

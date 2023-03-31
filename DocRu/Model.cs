using System.Collections;

namespace DocRu
{
    internal class Model
    {
        public static long SumDigits(long number)
        {
            if (number < 1)
            {
                throw new ArgumentException("Переданный аргумент: " + number + ", не является натуральным числом.");
            }

            long sum = 0;

            while (number != 0)
            {
                var digit = number % 10;
                sum += digit;

                number /= 10;
            }

            if (sum > 9)
            {
                sum = Model.SumDigits(sum);
            }
    
            return sum;
        }

        public static Hashtable MinCoinsCount(double number)
        {
            var table = new Hashtable
            {
                { "Pennies", 0 },
                { "Nickels", 0 },
                { "Dimes", 0 },
                { "Quarters", 0 }
            };

            if (number < 1)
            {
                return table;
            }

            var integer = (int)number;

            const int quarter = 25;
            const int dime = 10;
            const int nickel = 5;
            const int penni = 1;

            var temp = integer / quarter;
            if (temp > 0)
            {
                table["Quarters"] = temp;
                integer -= (quarter * temp);
            }

            temp = integer / dime;
            if (temp > 0)
            {
                table["Dimes"] = temp;
                integer -= (dime * temp);
            }

            temp = integer / nickel;
            if (temp > 0)
            {
                table["Nickels"] = temp;
                integer -= (nickel * temp);
            }

            temp = integer / penni;
            table["Pennies"] = temp;

            return table;
        }

        public static long SortingNumbers(long number)
        {
            
            var digitArray = number.ToString().Select(digit => long.Parse(digit.ToString())).ToArray();
            Array.Sort(digitArray);
            Array.Reverse(digitArray);

            return int.Parse(string.Join("", digitArray));
        }

        public static long PyramidLineSum(long linenNumber)
        {
            if (linenNumber < 1)
            {
                throw new ArgumentException("Переданный номер строки: " + linenNumber + ", меньше 1.");
            }

            var arr = new int[100000000];
            arr[0] = 1;

            for (var i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + 2;
            }

            long startIndex = 0;
            for (var i = 1; i < linenNumber; i++)
            {
                startIndex += i;
            }

            var endIndex = startIndex + linenNumber;
            var sumLine = 0;
            for (var i = startIndex; i < endIndex; i++)
            {
                sumLine += arr[i];

            }

            return sumLine;
        }

        public static int Five1()
        {
            const string name = "DocRu";

            return name.Length;
        }

        public static int Five2()
        {
            const string name = "Kirill";

            return name.LastIndexOf("l");
        }

        public static int Five3()
        {
            var c = 'D';

            return (int)SumDigits(c);
        }
    }
}
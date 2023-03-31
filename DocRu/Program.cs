using System.Collections;

namespace DocRu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sumDigits = Model.SumDigits(16);
            Console.WriteLine("Сумма цифр числа: " + sumDigits);

            var tableCoins = Model.MinCoinsCount(88);
            Console.WriteLine("Таблица монет:");
            foreach (DictionaryEntry de in tableCoins)
            {
                Console.WriteLine("{0} = {1}", de.Key, de.Value);
            }

            var maxNumber = Model.SortingNumbers(5921);
            Console.WriteLine("Максимальное число: " + maxNumber);

            var lineSum = Model.PyramidLineSum(2);
            Console.WriteLine("Сумма строки: " + lineSum);

            var five1 = Model.Five1();
            Console.WriteLine("Число: " + five1);

            var five2 = Model.Five2();
            Console.WriteLine("Число: " + five2);

            var five3 = Model.Five3();
            Console.WriteLine("Число: " + five3);
        }
    }
}
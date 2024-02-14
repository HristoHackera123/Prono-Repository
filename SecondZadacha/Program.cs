using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace SecondZadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Да се въведе n за броя на елементите в масив и да се декларира масив от цели числа
            byte n = byte.Parse(Console.ReadLine());
            int[] num = new int[n];
            //1. Да се въведът всички ел. в масива
            for (byte i = 0; i < num.Length; i++)
            {
                Console.Write($"num[{i}] = ");
                num[i] = int.Parse(Console.ReadLine());
            }
            //2. Да се отпеяати сумата от всички елементи
            long sum = 0L;
            int biggestNum = int.MinValue;
            byte biggestNumIndex = 0;
            for (byte i = 0;i < num.Length; i++)
            {
                sum += num[i];
                //4. Най-големият елемент в масива и на кой индекс е 
                if (num[i] > biggestNum)
                {
                    biggestNum = num[i];
                    biggestNumIndex = i;
                }
            }
            //3. Средно аретмитичното от вс. елементи
            long average = sum / num.Length;
            Console.WriteLine($"The sum of all numbers in the array = {sum} " +
                $"\nTheir average is {average} " +
                $"\nThe biggest number in the array is {biggestNum} at {biggestNumIndex}th index");
            Console.WriteLine("All the numbers are:");
            //5. Print all
            for (byte i = 0; i < num.Length ; i++)
            {
                Console.Write(num[i] + ", ");
            }
        }
    }
}

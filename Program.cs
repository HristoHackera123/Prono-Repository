﻿namespace Massive_input_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] grades = new float[13];/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string[] names = new string[13];
            for (byte i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"Име и оценка на {i + 14}-ти номер({i}): ");
                names[i] = Console.ReadLine();
                grades[i] = float.Parse(Console.ReadLine());
                Console.WriteLine($"{names[i]} ще има {grades[i]}");
            }
            string answer = "no";
            byte editSpace = 0;
            Console.Write("Would you like to edit something? (name/grades) ");
            answer = Console.ReadLine();
            if (answer == "grades")
            {
                Console.Write("Who? ");
                editSpace = byte.Parse(Console.ReadLine());
                Console.Write("To which grade? ");
                grades[editSpace] = byte.Parse(Console.ReadLine());
                Console.WriteLine($"{names[editSpace]} now has {grades[editSpace]}");
            }
            else if (answer == "name")
            {
                Console.Write("Which number? ");
                editSpace = byte.Parse(Console.ReadLine());
                Console.Write("Whats their new name? ");
                names[editSpace] = Console.ReadLine();
                Console.WriteLine($"The person in {editSpace + 14}({editSpace}) is now {names[editSpace]}");
            }
        }
    }
}
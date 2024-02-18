using System.Runtime.Serialization.Formatters;

namespace ArrayWithCmds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input an array: ");
            string[] array = Console.ReadLine().Split().ToArray();
            Console.Write("How many commands do you want?: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Give {n} commands");
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "Reverse":
                        Array.Reverse(array);
                        Console.WriteLine(string.Join(" ", array));
                        break;
                    case "Distinct":
                        array = array.Distinct().ToArray();
                        Console.WriteLine(string.Join(" ", array));
                        break;
                    default:
                        string[] result = command.Split().ToArray();
                        if (result[0] == "Replace")
                        {
                            array[int.Parse(result[1])] = result[2];
                        }
                        else
                        {
                            if (true)
                            {
                                Console.WriteLine("Nigger");
                            }
                            break;
                            
                        }
                        Console.WriteLine(string.Join(" ", array));
                        break;
                }
            }
        }
    }
}

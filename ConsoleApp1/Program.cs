using static ConsoleApp1.TwoArray;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            Random random = new Random();

            while (t)
            {
                Console.Write("Enter your first array size: ");
                bool success1 = int.TryParse(Console.ReadLine(), out int count1);
                Console.Write("Enter your second array size: ");
                bool success2 = int.TryParse(Console.ReadLine(), out int count2);
                Console.WriteLine("\n-------------------------------------------------------------\n");

                if (!success1 || !success2)
                {
                    Console.WriteLine("Enter the number!");
                    Console.WriteLine("\n-------------------------------------------------------------\n");
                }
                else
                {
                    int[] arr1 = new int[count1];
                    int[] arr2 = new int[count2];

                    for (int i = 0; i < count1; i++) arr1[i] = random.Next(10);
                    for (int i = 0; i < count2; i++) arr2[i] = random.Next(10);

                    Console.Write("Elements of First Array: ");
                    for (int i = 0; i < count1; i++) Console.Write(arr1[i] + " ");
                    Console.Write("\nElements of Second Array: ");
                    for (int i = 0; i < count2; i++) Console.Write(arr2[i] + " ");

                    Console.WriteLine("\n\n-------------------------------------------------------------\n");

                    Console.Write("New array: ");
                    MergeTwoArray(arr1, arr2);

                    Console.WriteLine("\n-------------------------------------------------------------\n");
                }

                Console.Write("Exit the program (y/n): ");
                string last = Console.ReadLine();
                if (last.Equals("y")) t = false;
                else t = true;
                Console.WriteLine("\n-------------------------------------------------------------\n");
            }
        }
    }
}

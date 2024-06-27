using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y, x, valueToAdd;
            int[,] matriz;
            try
            {
                string[] sizes = Console.ReadLine().Split(' ');
                List<int> total = new List<int>();


                x = int.Parse(sizes[0]);
                y = int.Parse(sizes[1]);
                matriz = new int[x, y];
                void ConstructorMatriz()
                {
                    for (int i = 0; i < x; i++)
                    {
                        string[] TimeArray = new string[y];
                        TimeArray = Console.ReadLine().Split();
                        valueToAdd = 0;
                        for (int j = 0; j < TimeArray.Length; j++)
                        {
                            matriz[i, j] = int.Parse(TimeArray[j]);
                            valueToAdd += int.Parse(TimeArray[j]);
                        }
                        total.Add(valueToAdd);
                    }
                }
                ConstructorMatriz();

                foreach (var item in total)
                {
                    Console.WriteLine("Total: " + item);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please, use only numbers and spaces to separete");
            }
        }
    }
}

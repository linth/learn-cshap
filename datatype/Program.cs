using System;

namespace datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 1;
            double height = 180;
            double weight = 70;
            string name = "May";

            int id2;
            double height2;
            double weight2;
            string name2;

            id2 = int.Parse(Console.ReadLine());
            height2 = double.Parse(Console.ReadLine());
            weight2 = double.Parse(Console.ReadLine());
            name2 = Console.ReadLine();

            Console.WriteLine("id: {0}; height: {1}; weight: {2}; name: {3}", id, height, weight, name);
            Console.WriteLine("id2: {0}; height2: {1}; weight2: {2}; name2: {3}", id2, height2, weight2, name2);
        }
    }
}

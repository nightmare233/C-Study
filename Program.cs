using System;

namespace CodeDev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Frank test!");
            string box = Box("frank",32);
            Console.WriteLine(box);
        }

        private static string Box(string name, int age){
            return name +" "+age+" is running...!";
        }
    }
}

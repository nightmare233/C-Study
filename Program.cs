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

            //传统试试创建对象：
            Box box2 = new Box();
                box2.Name = "frank";
                box2.Age = 32;
                box2.Title = "<You are the best>";
                box2.Readers = "3000000";
            //初始化器
            Box box3 = new Box(){
                Name = "Lee",
                Age = 23,
                Title = "developer"
            };

           string result =  box2.GetBoxName();
           string result2 = box3.GetBoxName();

           Console.WriteLine(result);
           Console.WriteLine(result2);
        }

        private static string Box(string name, int age){
            return name +" "+age+" is running...!";
        }
    }
}

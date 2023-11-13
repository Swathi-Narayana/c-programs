// class and objects

using System;

namespace HelloWorld
{
    class Car
    {
        string color = "red";

        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
        }
    }
}
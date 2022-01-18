using System;

namespace ConsoleApp1
{
    class Program
    {
        //Abstraction - Hiding the inner details - Cannot create object for abstract class - cannot be Sealed
        //Abstract method should be in abstract class - use Override
        //All derived classes should implement abstract methods in Base class/otherwise mark it as abstract
        //Class contains some abstract methods - Abstract Base class
        //Class contains all abstract methods - Pure Abstract class
        public abstract class Shape
        {
            public void print()
            {
                Console.WriteLine("Shapes");
            }
            public abstract void properties();
        }

        public class Square : Shape
        {
            public override void properties()
            {
                Console.WriteLine("Square - 4 Equal Sides, 4 corners");
            }

        }
        public class Circle : Shape
        {
            public override void properties()
            {
                Console.WriteLine("Circle - No sides, No corners");
            }

        }
        static void Main(string[] args)
        {
            Shape bc1 = new Square();
            bc1.print();
            bc1.properties();

            Shape bc2 = new Circle();
            bc2.properties();            
            
        }
    }
}

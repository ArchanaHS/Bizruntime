using System;

namespace Polymorphism1
{
    abstract class Shape 
        //abstract class->cannot create the object of class (inherited from another class).
    {
        public abstract int area();
        //abstract method -> can only used in abstract class.
    }
    class Rectangle: Shape
    {
        private int length;//fields
        private int width;
        public Rectangle(int a=0,int b = 0)//method with arguments.
        {
            length = a;
            width = b;
        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area");
            return (width * length);
        }
    }
    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10,7);//create an object.
            Double a = r.area();
            Console.WriteLine("Area:{0}", a);
            Console.ReadKey();
        }
    }
}

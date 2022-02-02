using System;
using System.Windows;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class ShapeFactory
    {
        GeometricShape getShape(ShapeType type)
        {
            
            switch(type)
            {
                case == LINE:
                    Console.WriteLine("L");
                case == CIRCLE:
                    Console.WriteLine("C");
                case == RECTANGLE:
                    Console.WriteLine("R");
                case == TRIANGLE:
                    Console.WriteLine("T");
            }
        }
    }
    abstract interface GeometricShape<ShapeType>
    {
        void draw()
        {

        }
    }
    class Line : GeometricShape<ShapeType>
    {

    }

    class Circle : GeometricShape<ShapeType>
    {

    }

    class Rectangle : GeometricShape<ShapeType>
    {

    }
}

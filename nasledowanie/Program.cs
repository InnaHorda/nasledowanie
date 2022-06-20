using System;


namespace nasledowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            bool start = true;
            while (start)
            {
                Console.WriteLine("\nВыберите геометрическую фигуру\n треугольник - 1, окружность - 2, выйти - 3");
                try
                {
                    int choose = int.Parse(Console.ReadLine());
                    if (choose == 1)
                    { Triangle triangle1 = new Triangle(2, 6, 4, 5);
                        Triangle triangle2 = new Triangle(2, 5, 4, 5);
                        triangle2.print();
                        triangle1.Draw(); }
                    else if (choose == 2)
                    {
                        Circle circle1 = new Circle(4, 5, 2);
            circle1.Draw_Circle();
                        circle1.PrintC();
                    }
                    else if (choose == 3) start = false;
                    else Console.WriteLine();
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
           
            
        }
    }
}
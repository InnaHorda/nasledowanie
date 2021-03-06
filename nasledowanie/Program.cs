using System;


namespace nasledowanie
{
    class Figury
    {
        public int X{ get; set; }
        public int Y { get; set; }
        public Figury(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    class Triangle : Figury
    {
        public int Str1 { get; set; }
        public int Str2 { get; set; }


        public Triangle(int str1, int str2, int x, int y) : base(x, y)
        {
            this.Str1 = str1;
            this.Str2 = str2;
           
           
        }
        public void Draw()
        {
           
        }
        public void Print()
        {
            Console.WriteLine("первая точка кординаты x: {0}, вторая кординаты У:{1},перевая сторона: {2}, сторая сторона: {3}",X, Y, Str1, Str2);
        }

    }
    class Circle : Figury
    {
        public int Radius { get; set; }
        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.Radius = radius;
        }
        public void Draw_Circle()
        { 
        }

        public void PrintC()
        {
            Console.WriteLine("первая точка кординаты x: {0}, вторая кординаты У:{1},радиус кругу: {2}", X, Y, Radius);
        }
    }


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
                        triangle2.Print();
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
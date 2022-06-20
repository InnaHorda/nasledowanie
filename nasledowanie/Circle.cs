using System;


namespace nasledowanie
{
    class Circle : Figury
    {
        public int radius { get; set; }
        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }
        public void Draw_Circle()
        { 
        }

        public void PrintC()
        {
            Console.WriteLine("первая точка кординаты x: {0}, вторая кординаты У:{1},радиус кругу: {2}", x, y, radius);
        }
    }
}
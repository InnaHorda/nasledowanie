using System;


namespace nasledowanie
{
    class Triangle : Figury
    {
        public int str1 { get; set; }
        public int str2 { get; set; }


        public Triangle(int str1, int str2, int x, int y) : base(x, y)
        {
            this.str1 = str1;
            this.str2 = str2;
           
           
        }
        public void Draw()
        {
           
        }
        public void print()
        {
            Console.WriteLine("первая точка кординаты x: {0}, вторая кординаты У:{1},перевая сторона: {2}, сторая сторона: {3}",x, y, str1, str2);
        }

    }
}
using System;


namespace OOPExcercises
{
    public class Rectangle
    {
        public int Width { get; protected set; }
        public int Height { get; protected set; }

        public Rectangle (int width,int height)
        {
            Width = width;
            Height = height;
        }

        public int area() => Width * Height;
        public int perimeter() => (2 * (Width + Height));
        
    }
}

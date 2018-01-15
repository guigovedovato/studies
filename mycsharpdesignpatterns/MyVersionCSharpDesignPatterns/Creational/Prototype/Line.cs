using System;
using System.Collections.Generic;
using System.Text;

namespace MyVersionCSharpDesignPatterns.Creational.Prototype
{
    class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public Line DeepCopy()
        {
            var newStart = new Point { X = Start.X, Y = Start.Y };
            var newEnd = new Point { X = End.X, Y = End.Y };
            return new Line { Start = newStart, End = newEnd };
        }

        public override string ToString()
        {
            return $"Start(x: {Start.X}, y: {Start.Y}), End(x: {End.X}, y: {End.Y})";
        }
    }
}

﻿using System;
using static System.Math;

namespace Examples.Chapter1
{
   namespace CSharp7
   {
      class Circle
      {
         public Circle(double radius) { Radius = radius; }

         public double Radius { get; }

         public (double Circumference, double Area) Stats
            => (Circumference, Area);

         public double Circumference
            => PI * 2 * Radius;

         public double Area
         {
            get
            {
               double Square(double d) => Pow(d, 2);
               return PI * Square(Radius);
            }
         }
      }
   }

   namespace CSharp9
   {
      interface Shape { }

      record Rectangle(double Length, double Height) : Shape;

      record Circle(double Radius) : Shape;

      static class Geometry
      {
         public static double Area(this Shape shape)
            => shape switch
            {
               Circle c => PI * Pow(c.Radius, 2),
               Rectangle r => r.Length * r.Height,
               _ => throw new ArgumentException(),
            };
      }
   }
}

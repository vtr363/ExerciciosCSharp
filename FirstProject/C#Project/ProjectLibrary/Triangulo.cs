using System;

namespace ProjectLibrary
{
    public class Triangulo
    {
        private double A;
        private double B;
        private double C;
        
        public Triangulo(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

        }

        public double area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
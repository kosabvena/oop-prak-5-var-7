using System;

interface IArithmetic<T>
{
    T Add(T a, T b);
    T Subtract(T a, T b);
    T Multiply(T a, T b);
    T Parse(string s);
    double ToDouble();
}
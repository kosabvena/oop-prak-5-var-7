using System;

struct Integer : IComparable<Integer>, IArithmetic<Integer>
{
    public int value;
    public Integer(int v) { value = v; }

    public int CompareTo(Integer other) { return value.CompareTo(other.value); }
    public Integer Add(Integer a, Integer b) { return new Integer(a.value + b.value); }
    public Integer Subtract(Integer a, Integer b) { return new Integer(a.value - b.value); }
    public Integer Multiply(Integer a, Integer b) { return new Integer(a.value * b.value); }
    public Integer Parse(string s) { return new Integer(Convert.ToInt32(s)); }
    public double ToDouble() { return value; }
    public override string ToString() { return value.ToString(); }
}
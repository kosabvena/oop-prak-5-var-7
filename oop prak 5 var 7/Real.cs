using System;

struct Real : IComparable<Real>, IArithmetic<Real>
{
    public double value;
    public Real(double v) { value = v; }

    public int CompareTo(Real other) { return value.CompareTo(other.value); }
    public Real Add(Real a, Real b) { return new Real(a.value + b.value); }
    public Real Subtract(Real a, Real b) { return new Real(a.value - b.value); }
    public Real Multiply(Real a, Real b) { return new Real(a.value * b.value); }
    public Real Parse(string s) { return new Real(Convert.ToDouble(s)); }
    public double ToDouble() { return value; }
    public override string ToString() { return value.ToString(); }
}
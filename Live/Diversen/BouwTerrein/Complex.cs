
namespace BouwTerrein;

internal class Complex : ICloneable
{
    public int Real { get; set; }
    public int Imaginary { get; set; }

    public static Complex operator+(Complex a, Complex b)
    {
        return new Complex { Real = a.Real + b.Real, Imaginary = a.Imaginary + b.Imaginary };
    }

    public override string ToString()
    {
        return $"({Real} + {Imaginary}i)";
    }

    public object Clone()
    {
        return new Complex { Real = this.Real, Imaginary = this.Imaginary };
    }

    public Complex(Complex x)
    {
        this.Real = x.Real;
        this.Imaginary = x.Imaginary;
    }
    public Complex()
    {
        
    }
}

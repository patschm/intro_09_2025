
namespace BouwTerrein;

internal class Complex<T> : ICloneable where T : IFormattable
{
    public T Real { get; set; }
    public T Imaginary { get; set; }

   
    public override string ToString()
    {
        return $"({Real} + {Imaginary}i)";
    }

    public object Clone()
    {
        return new Complex<T> { Real = this.Real, Imaginary = this.Imaginary };
    }

    public Complex(Complex<T> x)
    {
        this.Real = x.Real;
        this.Imaginary = x.Imaginary;
    }
    public Complex()
    {
        
    }
}

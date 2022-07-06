//Create class Fraction with private int fields numerator and denominator that can only be initialized on creation or in constructor
//Create a constructor to initialize these values
//Define operators unary and binary + and - 
//Define the ! operator that will return reversed fraction - with numerator as denominator and denominator as numerator
//Define binary  * and / operations.
//All operations should return simplified fractions.
//Define ToString() method which will return string representing Fraction in the format numerator / denominator. 
//Value should be simplified: numerator and denominator divided by the greatest common divisor. 
//if  numerator and denominator are both negative, the fraction should become positive. 
//If only denominator is negative the sign should be outputted before numerator without space.
//Define Equals  method and operators == and !=. Fractions are equal if their simplified versions are equal. 
//(for example, 20/25 isequal to 4/5)
//Define GetHashCode() method with implementation at your choise.

class Fraction
{
    readonly int numerator, denominator;
    private Fraction()
    { }
    public Fraction(int _num, int _denom)
    {
        numerator = _num;
        denominator = _denom;
    }
    public static Fraction operator +(Fraction a) => a;
    public static Fraction operator -(Fraction a) => -a;
    public static Fraction operator !(Fraction a) => new Fraction(a.denominator, a.numerator);
    public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);
    public static Fraction operator /(Fraction a, Fraction b) => new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);
    public static Fraction operator +(Fraction a, Fraction b)
    {
        int nsk = NSK(a.denominator, b.denominator);
        int c = nsk / a.denominator * a.numerator + nsk / b.denominator * b.numerator;
        int nsd = NSD(c, nsk);
        if (nsd == 0) return new Fraction(c, nsd);
        return new Fraction(c / nsd, nsk / nsd);
    }
    public static Fraction operator -(Fraction a, Fraction b)
    {
        int nsk = NSK(a.denominator, b.denominator);
        int c = nsk / a.denominator * a.numerator - nsk / b.denominator * b.numerator;
        int nsd = NSD(c, nsk);
        if (nsd == 0) return new Fraction(c, nsd);
        return new Fraction(c / nsd, nsk / nsd);
    }
    private static int NSD(int m, int n)
    {
        if (m < 0 || n < 0) return 0;
        while (m != n)
        {
            if (m > n) m -= n;
            if (n > m) n -= m;
        }
        return m;

    }
    private static int NSK(int m, int n) => m * n / NSD(m, n);
    public override string ToString()
    {
        int c = NSD(numerator, denominator);
        int n = numerator / c;
        int d = denominator / c;
        if (d < 0 && n < 0)
        {
            d = -d;
            n = -n;
        }
        if (d < 0)
        {
            d = -d;
            return " -" + n + " / " + d;
        }
        return n + " / " + d;
    }
    public static Fraction simplified(Fraction a) => new Fraction(a.numerator / NSD(a.numerator, a.denominator), a.denominator / NSD(a.numerator, a.denominator));
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }
    public static bool operator ==(Fraction a, Fraction b)
    {
        if (simplified(a) == simplified(b)) return true;
        return false;
    }
    public static bool operator !=(Fraction a, Fraction b)
    {

        if (simplified(a) == simplified(b)) return false;
        return true;
    }
}



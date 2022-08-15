//Create a program that can be used for calculation of 4 arithmetic operations (+, -, *, /) according to tasks:
//1) declare a delegate CalcDelegate referring to a function Calc with three parameters (two numbers and one - operation sign) and a numerical result;
//2) define a class CalcProgram and within this class:
//2.1) define a static function Calc for computation with the same signature as the delegate. Note: in case of denominator = 0, the function returns 0.
//2.2) create a public object funcCalc of delegate type and pass the function Calc as an argument.

public delegate double CalcDelegate(double f1, double f2, char s);

class CalcProgram
{
    public CalcDelegate funcCalc = Calc;
    public static double Calc(double f1, double f2, char s)
    {
        return s switch
        {
            '+' => f1 + f2,
            '-' => f1 - f2,
            '*' => f1 * f2,
            '/' => f2 == 0 ? 0 : f1 / f2,
            _ => 0.0,
        };
    }
}


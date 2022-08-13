//Inside a class ShowPower define a static method SuperPower(). SuperPower() has two integer input parameters: number and degree. The method will  calculate the power of a given number according to degree parameter.
//Note: Don 't use Pow().
//The method involves to yield the intermediate result of the calculation on the each iteration.
//For example, when calling the method SuperPower():


using System.Collections;
class ShowPower : IEnumerable
{
    public static IEnumerable SuperPower(int number, int degree)
    {
        Single result = 1;
        if (degree == 0)
        {
            yield return result;
            yield break;
        }
        if (degree > 0)
        {
            for (int i = 0; i < degree; i++)
            {
                yield return result *= number;
            }
        }
        if (degree < 0)
        {
            Single power = 1;
            for (int i = 0; i > degree; i--)
            {
                result = 1;
                power *= number;
                result /= power;
                yield return result;
            }
        }
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

}

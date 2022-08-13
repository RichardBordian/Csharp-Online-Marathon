//Within the class, ShowPowerRange create a static method PowerRanger() that takes in integer degree, start, finish. 
//The method returns all the numbers from the range [start, finish] (inclusive and finish > 0 and start > 0) that are equal to the degree-th power of any positive integer.
//In the case start > finish, or start < 0, or finish < 0 the method returns 0.
//The method involves yielding the intermediate result on each iteration.
//For example, when calling the method PowerRanger():

using System.Collections;
class ShowPowerRange : IEnumerable
{
    public static IEnumerable PowerRanger(int degree, int start, int finish)
    {
        Single result = 1;
        if (start > finish || start < 0 || finish < 0)
        {
            yield return (Single)0;
            yield break;
        }
        if (degree == 0)
        {
            yield return result;
            yield break;
        }

        for (int i = 1; i <= finish; i++)
        {
            if (degree == 1)
            {
                yield return (Single)i;
                continue;
            }

            result = 1;
            for (int j = 0; j < degree; j++) result *= i;
            if (result > start && result <= finish) yield return result;
        }
    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }

}

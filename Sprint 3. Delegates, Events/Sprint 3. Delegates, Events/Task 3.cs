//Define a static method ListWithPositive that receives the List of negative and positive elements as a parameter. 
//The method  ListWithPositive uses the FindAll method on the List type. The argument to FindAll will use the anonymous method syntax. 
//The predicate in FindAll will use a boolean expression that is evaluated, causing the anonymous function to return true if the argument is positive and less then or equal 10.
//The method  ListWithPositive returns the list of positive elements.

class ListProgram
{

    public static List<int> ListWithPositive(List<int> abc)
    {
        return abc.FindAll(abc => abc > 0 && abc <= 10);
    }

}


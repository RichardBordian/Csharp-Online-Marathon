public interface ILead
{
    void AssignTask();
    void CreateSubTask();
    void WorkOnTask();
}
public interface IManager
{
    void AssignTask();
    void CreateSubTask();
}
public interface IProgrammer
{
    void WorkOnTask();
}
class Programmer : IProgrammer
{
    public void WorkOnTask()
    {
    }
}
class TeamLead : ILead
{
    public void AssignTask()
    {

    }
    public void CreateSubTask()
    {

    }
    public void WorkOnTask()
    {

    }
}
class Manager : IManager
{
    public void AssignTask()
    { }
    public void CreateSubTask()
    { }
}
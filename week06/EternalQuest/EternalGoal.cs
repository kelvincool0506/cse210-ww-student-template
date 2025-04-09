public class EternalGoal : Goal
{
    private int _points;

    public EternalGoal(string name, int points) : base(name)
    {
        _points = points;
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetStatus()
    {
        return "[ ] (eternal)";
    }
}

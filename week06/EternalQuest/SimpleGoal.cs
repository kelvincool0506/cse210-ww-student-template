public class SimpleGoal : Goal
{
    private bool _isComplete;
    private int _points;

    public SimpleGoal(string name, int points) : base(name)
    {
        _points = points;
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStatus()
    {
        return IsComplete() ? "[X]" : "[ ]";
    }
}

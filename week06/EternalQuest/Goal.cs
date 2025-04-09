using System;

public abstract class Goal
{
    private string _name;

    public Goal(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStatus();
}

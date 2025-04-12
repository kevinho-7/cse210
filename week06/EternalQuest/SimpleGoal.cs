using System;
using System.Drawing;

public class SimpleGoal : Goal
{
    protected bool _isComplete;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points) 
    {
        _isComplete = false;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }
        else
        {
            _isComplete = true;
            return _points;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal: {_shortName}, {_description}, {_points}, {_isComplete}";
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description}) - {_points} points";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) - {_points} points";
        }
    }
}
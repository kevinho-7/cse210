using System;
using System.Drawing;

public class EternalGoal : Goal
{
    protected bool _isComplete;

    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) 
    {
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal: {_shortName}, {_description}, {_points}, {_isComplete}";
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description})";
    }
}
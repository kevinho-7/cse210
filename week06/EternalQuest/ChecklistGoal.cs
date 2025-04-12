public class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }


    public override int RecordEvent()
    {
        if (_amountCompleted >= _target)
        {
            return 0;
        }
        else
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                return _points + _bonus;
            }
            return _points;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal: {_shortName}, {_description}, {_points}, {_amountCompleted}, {_target}, {_bonus}, {IsComplete()}";
    }
}
public class Swimming : Activity
{
    protected int _laps;
    public Swimming(int laps, string actName, int actDuration, double actDistance, double actSpeed, double actPace) 
        : base(actName, actDuration, actDistance, actSpeed, actPace)
    {
        _laps = laps;
    }

    public override string GetActName()
    {
        return _ActName; 
    }

    public override int GetActDuration()
    {
        return _ActDuration; 
    }

    public override double GetActDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetActSpeed()
    {
        return GetActDistance() / _ActDuration * 60;
    }

    public override double GetActPace()
    {
        
        return _ActDuration / GetActDistance();
    }

    public override string GetSummary()
    {
        return $"{GetActDate()} {GetActName()} ({GetActDuration()} min): Distance {GetActDistance()} km, Speed: {GetActSpeed()} kph, Pace: {GetActPace()} min per km";
    }

}
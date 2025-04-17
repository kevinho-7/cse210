public class Cycling : Activity
{
    public Cycling(string actName, int actDuration, double actDistance, double actSpeed, double actPace) 
        : base(actName, actDuration, actDistance, actSpeed, actPace)
    {
        _ActSpeed = actSpeed;
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
        return _ActSpeed / 60 * _ActDuration;
    }

    public override double GetActSpeed()
    {
        return _ActSpeed; 
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
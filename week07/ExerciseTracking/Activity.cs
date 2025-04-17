public abstract class Activity 
{
    protected string _ActName;
    protected int _ActDuration;
    protected string _ActDate;
    protected double _ActDistance;
    protected double _ActSpeed;
    protected double _ActPace;

    public Activity(string actName, int actDuration, double actDistance, double actSpeed, double actPace) 
    {
        _ActName = actName;
        _ActDuration = actDuration;
        _ActDistance = actDistance;
        _ActSpeed = actSpeed;
        _ActPace = actPace;
    }

    public string GetActDate()
    {
        return _ActDate = DateTime.Today.ToString("dd MMM yyyy");
    }
    public abstract string GetActName();
    public abstract int GetActDuration();
    public abstract double GetActDistance();
    public abstract double GetActSpeed();
    public abstract double GetActPace();
    public abstract string GetSummary();



}
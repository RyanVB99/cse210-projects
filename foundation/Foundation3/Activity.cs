public abstract class Activity
{
    protected string _date;
    protected float _duration;

    public Activity(string date, float duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract float CalcDistance();
    public abstract float CalcSpeed();
    public abstract float CalcPace();

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {this.GetType().Name} ({_duration} min): Distance: {CalcDistance():0.0} km, Speed: {CalcSpeed():0.0} km/h, Pace: {CalcPace():0.00} min/km");
    }
}

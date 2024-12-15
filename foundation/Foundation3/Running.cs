public class Running : Activity
{
    private float _distance;

    public Running(string date, float duration, float distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override float CalcDistance()
    {
        return _distance;
    }

    public override float CalcSpeed()
    {
        float speed = _distance/_duration * 60;
        return speed;
    }

    public override float CalcPace()
    {
        float pace = _duration / _distance;
        return pace;
    }
}

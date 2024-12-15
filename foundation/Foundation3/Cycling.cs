public class Cycling : Activity
{
    private float _speed;

    public Cycling(string date, float duration, float speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override float CalcDistance()
    {
        float distance = _speed * _duration / 60;
        return distance;
    }

    public override float CalcSpeed()
    {
        float speed = _speed;
        return speed;
    }

    public override float CalcPace()
    {
        float pace = 60 / _speed;
        return pace;
    }
}

public class Swimming : Activity
{
    private int _numLaps;

    public Swimming(string date, float duration, int numLaps) : base(date, duration)
    {
        _numLaps = numLaps;
    }

    public override float CalcDistance()
    {
        float distance = _numLaps * 50 / 1000;
        return distance;
    }

    public override float CalcSpeed()
    {
        float speed = CalcDistance() / _duration * 60;
        return speed;
    }

    public override float CalcPace()
    {
        float pace = _duration / CalcDistance();
        return pace;
    }
}

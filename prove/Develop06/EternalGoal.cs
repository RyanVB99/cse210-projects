public class EternalGoal : Goal {
    public EternalGoal(string name, string description, int points) : base(name, description, points) {}

    public override int MarkComplete() {
        return _points;
    }

    public override bool IsComplete() {
        return false;
    }

    public override string ConvertToString() {
        return $"{_name},{_description},{_points}";
    }
}

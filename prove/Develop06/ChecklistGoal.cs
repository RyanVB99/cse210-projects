public class ChecklistGoal : Goal {
    private int _totalSteps;
    private int _amountCompleted;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int totalSteps, int bonusPoints, int amountCompleted = 0) : base(name, description, points) {
        _totalSteps = totalSteps;
        _bonusPoints = bonusPoints;
        _amountCompleted = amountCompleted;
    }

    public override int MarkComplete() {
        if (_amountCompleted < _totalSteps) {
            _amountCompleted++;
            if (_amountCompleted == _totalSteps) {
                return _points + _bonusPoints;
            }
            return _points;
        }
        return 0;
    }

    public override bool IsComplete() {
        return _amountCompleted >= _totalSteps;
    }

    public override string ConvertToString() {
        return $"{_name},{_description},{_points},{_totalSteps},{_amountCompleted},{_bonusPoints}";
    }

    public override string DisplayString() {
        return $"{_name} ({_description}) -- Currently completed: {_amountCompleted}/{_totalSteps}";
    }
}

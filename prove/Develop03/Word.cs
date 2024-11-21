class Word {
    public Word(string text) {
        _isHidden = false;
        _text = text;
    }

    public void Hide() {
        for (int i = 0; i < _text.Length; i++) {
            if (_text[i] != ' ') {
                _text = _text.Remove(i, 1);
                _text = _text.Insert(i, "_");
            }
        }
        _isHidden = true;
    }

    public void Show() {
        Console.WriteLine(_text);
    }

    public string GetDisplayText() {
        return _text;
    }

    public bool IsHidden() {
        return _isHidden;
    }

    private string _text;

    private bool _isHidden;
}
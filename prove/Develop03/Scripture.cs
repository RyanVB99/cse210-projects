using Random = System.Random;

class Scripture {
    public void HideRandomWords(int numberToHide) {
        if (numberToHide > _words.Count - _hiddenIndexes.Count) {
            numberToHide = _words.Count - _hiddenIndexes.Count;
        }

        for (int i = 0; i < numberToHide; i++) {
            int randomIndex = new Random().Next(0, _words.Count);
            while (_hiddenIndexes.Contains(randomIndex)) {
                randomIndex = new Random().Next(0, _words.Count);
            }
            _words[randomIndex].Hide();
            _hiddenIndexes.Add(randomIndex);
        }
    }

    public void GetDisplayText() {
        for (int i = 0; i < _words.Count; i++) {
            Console.Write(_words[i].GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public bool IsFullyHidden() {
        for (int i = 0; i < _words.Count; i++) {
            if (!_words[i].IsHidden()) {
                return false;
            }
        }
        return true;
    }

    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private List<int> _hiddenIndexes = new List<int>();

    public Scripture(Reference reference, string text) {
        _reference = reference;
        string[] words = text.Split(' ');
        foreach (string word in words) {
            _words.Add(new Word(word));
        }
    }
}
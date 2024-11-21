class Reference {
    public static string GetDisplayText() {
        return _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
    }

    private static string _book;
    private static int _chapter;
    private static int _verse;
    private static int _endVerse;

    public Reference(string book, int chapter, int verse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

        public Reference(string book, int chapter, int verse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }
}
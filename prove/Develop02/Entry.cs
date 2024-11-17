using System.Runtime.InteropServices;

class Entry
{
    public void Display() {
        System.Console.WriteLine(_date);
        System.Console.WriteLine(_prompt);
        System.Console.WriteLine(_response);
        System.Console.WriteLine("Mood: ");
        System.Console.WriteLine(_todays_mood);
    }

    public string _date;
    public string _prompt;
    public string _response;
    public string _todays_mood;
}
class Journal
{
    public void Display() {
        Console.WriteLine("Journal Entries");
        Console.WriteLine("---------------");
        foreach (Entry entry in _entries) {
            entry.Display();
        }
    }

    public void Save(string filename) {
        try {
            Console.WriteLine("Saving entries to file: " + filename);
            using (StreamWriter writer = new StreamWriter(filename)) {
                foreach (Entry entry in _entries) {
                    writer.WriteLine(entry._date);
                    writer.WriteLine(entry._prompt);
                    writer.WriteLine(entry._response);
                    writer.WriteLine(entry._todays_mood);
                    writer.WriteLine("-|-");
                    Console.WriteLine("Saved entry");
                }
            }
            Console.WriteLine("Entries successfully saved to " + filename);
        } catch (Exception ex) {
            Console.WriteLine("An error occurred while saving entries: " + ex.Message);
        }
    }

    public void Load(string filename) {
        try {
            Console.WriteLine("Loading entries from file: " + filename);
            _entries.Clear();
            using (StreamReader reader = new StreamReader(filename)) {
                while (!reader.EndOfStream) {
                    Entry entry = new Entry();
                    entry._date = reader.ReadLine();
                    entry._prompt = reader.ReadLine();
                    entry._response = reader.ReadLine();
                    entry._todays_mood = reader.ReadLine();
                    reader.ReadLine();
                    _entries.Add(entry);
                    Console.WriteLine("Loaded entry");
                }
            }
            Console.WriteLine("Entries successfully loaded from " + filename);
        } catch (FileNotFoundException) {
            Console.WriteLine("File not found: " + filename);
        } catch (Exception ex) {
            Console.WriteLine("An error occurred while loading entries: " + ex.Message);
        }
    }

    public void AddEntry(string response, string prompt, string mood) {
        Entry entry = new Entry();
        entry._date = DateTime.Now.ToString("MM/dd/yyyy");
        entry._prompt = prompt;
        entry._response = response;
        entry._todays_mood = mood;
        _entries.Add(entry);
        Console.WriteLine("Added entry");
    }

    public List<Entry> _entries = new List<Entry>();
}
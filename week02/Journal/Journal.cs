using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<string> _promptText = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What is one thing I learned today?",
        "What was the strongest emotion I felt today?",
        "If I could relive one moment today, what would it be?"
    };

    public void AddEntry()
    {
        Random random = new Random();
        string prompt = _promptText[random.Next(_promptText.Count)];

        Console.WriteLine("Here’s your prompt:");
        Console.WriteLine(prompt);

        Console.Write("Your response: ");
        string response = Console.ReadLine();
        DateTime date = DateTime.Now;

        Entry newEntry = new Entry(prompt, response, date);
        _entries.Add(newEntry);
        Console.WriteLine("Your entry has been recorded.\n");
    }

    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.\n");
            return;
        }
        Console.WriteLine("Journal Entries:");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter a filename to save the journal (e.g., journal.txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved successfully.\n");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter the filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                DateTime date = DateTime.Parse(parts[0]);
                string prompt = parts[1];
                string response = parts[2];

                Entry entry = new Entry(prompt, response, date);
                _entries.Add(entry);
            }

            Console.WriteLine("Journal loaded successfully.\n");
        }
        else
        {
            Console.WriteLine("The file does not exist.\n");
        }
    }
}
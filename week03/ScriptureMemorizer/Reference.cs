using System;

namespace ScriptureHiding
{
    // Class representing the scripture reference
    class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int? _endVerse; // Nullable for optional end verse

        // Constructor for a single verse
        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = null;
        }

        // Constructor for a verse range
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = startVerse;
            _endVerse = endVerse;
        }

        // Method to get the display text of the reference
        public string GetDisplayText()
        {
            return _endVerse.HasValue
                ? $"{_book} {_chapter}:{_verse}-{_endVerse}"
                : $"{_book} {_chapter}:{_verse}";
        }
    }
}
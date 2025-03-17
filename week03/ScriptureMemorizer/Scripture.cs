using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureHiding
{
    // Class representing the scripture
    class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        // Constructor
        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        // Method to hide a specified number of random words
        public void HideRandomWords(int numberToHide)
        {
            var random = new Random();
            for (int i = 0; i < numberToHide; i++)
            {
                // Select a random word and hide it
                int index = random.Next(_words.Count);
                _words[index].Hide();
            }
        }

        // Method to check if all words are hidden
        public bool IsCompletelyHidden()
        {
            return _words.All(word => word.IsHidden());
        }

        // Method to get the display text of the scripture
        public string GetDisplayText()
        {
            string wordsDisplay = string.Join(" ", _words.Select(word => word.GetDisplayText()));
            return $"{_reference.GetDisplayText()}\n{wordsDisplay}";
        }
    }
}
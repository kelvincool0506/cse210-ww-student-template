namespace ScriptureHiding
{
    // Class representing a single word in the scripture
    class Word
    {
        private string _text;
        private bool _isHidden;

        // Constructor
        public Word(string text)
        {
            _text = text;
            _isHidden = false; // Words are visible by default
        }

        // Method to hide the word
        public void Hide()
        {
            _isHidden = true;
        }

        // Method to check if the word is hidden
        public bool IsHidden()
        {
            return _isHidden;
        }

        // Method to get the display text of the word (shows underscores if hidden)
        public string GetDisplayText()
        {
            return _isHidden ? new string('_', _text.Length) : _text;
        }
    }
}
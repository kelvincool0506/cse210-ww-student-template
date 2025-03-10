using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;

    // Constructor to initialize the list of prompts
    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What is one thing I learned today?",
            "What was the strongest emotion I felt today?",
            "If I could relive one moment today, what would it be?"
        };
    }

    // Method to get a random prompt from the list
    public string GetRandomPrompt()
    {
        if (_prompts == null || _prompts.Count == 0)
        {
            throw new InvalidOperationException("The prompts list is empty or not initialized.");
        }

        Random random = new Random();
        int index = random.Next(_prompts.Count); // Get a random index
        return _prompts[index]; // Return the prompt at the random index
    }
}
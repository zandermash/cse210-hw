using System.Security.Cryptography;

class PromptGenerator
{
    public string Prompts()
    {

    List<string> ranPrompts = new List<string>
    {
        "What is a habit you want to build?",
        "Describe a recent moment where you felt completely at peace. What exactly were you doing, and who was with you?",
        "Write about a complex project you've been putting off.",
        "What was the most challenging event or task you faced today, and how did you handle it?",
        "Identify one specific task or objective you accomplished today.",
        "Describe a moment today that shifted your mood, focus, or perspective.",
        "What is a piece of new information you encountered today, and how does it affect your current understanding of that topic?",
        "What is the most important task you need to complete tomorrow, and what is the immediate first step required to start it?",
        "Identify a recent obstacle that has been slowing your progress. What is something you could do resolve it?",
        "Evaluate a habit you are currently attempting to build or break. How did it effect you today?",
        "Where do you feel your time could have been spent more effectively today?",
        "How was your focus today? What helped you focus and what caused you to lose focus?",
        "What is one aspect of your daily routine that felt inefficient today, and how can it be optimized for tomorrow?",
        "What is a pending decision you have been avoiding, and what specific information do you still need to make it?",
        "What is a short-term, measurable goal you can reasonably achieve by the end of this week?",
        "Look at your upcoming schedule for the next three days. What is one low-effort preparation you can do tonight to make that period less stressful?"
    };

    string prompt = ranPrompts[Random.Shared.Next(ranPrompts.Count)];
    return prompt;
    }
}


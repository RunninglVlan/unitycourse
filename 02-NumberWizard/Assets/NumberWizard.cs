using UnityEngine;

class NumberWizard : MonoBehaviour
{
    private const int MAX = 1000;
    private const int MIN = 0;

    private int max;
    private int min;
    private int guess;

    void Start()
    {
        max = MAX;
        min = MIN;

        Terminal.WriteLine("Welcome to Number Wizard");
        Terminal.WriteLine();
        Terminal.WriteLine("Pick a number, don't tell me what it  is...");

        Terminal.WriteLine($"Lowest and highest possible numbers   are {MIN} and {MAX}");

        nextGuess();
        Terminal.WriteLine("Press UP arrow for higher, DOWN arrow for lower, ENTER for equal");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            nextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            nextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            printAnswer();
        }
    }

    private void nextGuess()
    {
        int previousGuess = guess;
        for (int i = 0; i < max - min; i++)
        {
            int nextGuess = Random.Range(min, max + 1);
            if (previousGuess != nextGuess)
            {
                guess = nextGuess;
                printQuestion();
                return;
            }
        }
        printAnswer();
    }

    private void printQuestion()
    {
        Terminal.WriteLine($"Is your number higher [↑] or lower [↓]than {guess}? Maybe it is equal [Enter]?");
    }

    private void printAnswer()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine($"You picked {guess}");
        Terminal.WriteLine();
        Start();
    }
}

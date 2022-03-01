using UnityEngine;
using TMPro;

class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;

    [SerializeField] TextMeshProUGUI guessTextComponent;

    private int guess;

    void Start()
    {
        nextGuess();
    }

    public void setMinToGuess()
    {
        min = guess + 1;
        nextGuess();
    }

    public void setMaxToGuess()
    {
        max = guess - 1;
        nextGuess();
    }

    private void nextGuess()
    {
        if (max == min)
        {
            setGuess(min);
            return;
        }
        int previousGuess = guess;
        for (int i = 0; i < max - min; i++)
        {
            int nextGuess = Random.Range(min, max + 1);
            if (previousGuess != nextGuess)
            {
                setGuess(nextGuess);
                return;
            }
        }
    }

    private void setGuess(int guess)
    {
        this.guess = guess;
        guessTextComponent.text = guess.ToString();
    }
}

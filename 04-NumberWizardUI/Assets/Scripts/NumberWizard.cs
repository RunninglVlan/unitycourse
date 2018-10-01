using UnityEngine;
using TMPro;

class NumberWizard : MonoBehaviour
{

    [SerializeField]
    int max;
    [SerializeField]
    int min;

    [SerializeField]
    TextMeshProUGUI guessTextComponent;

    private int guess;

    void Start()
    {
        nextGuess();
    }

    public void setMinToGuess()
    {
        min = guess;
        nextGuess();
    }

    public void setMaxToGuess()
    {
        max = guess;
        nextGuess();
    }

    private void nextGuess()
    {
        int previousGuess = guess;
        for (int i = 0; i < max - min; i++)
        {
            int nextGuess = Mathf.FloorToInt(Random.Range(min, max + 1));
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

using UnityEngine;

class NumberWizard : MonoBehaviour {

	private const int MAX = 1000;
	private const int MIN = 0;

	private int max;
	private int min;
	private int guess;

	void Start() {
		max = MAX;
		min = MIN;
		
		print("Welcome to Number Wizard");

		print("The highest number you can pick is " + MAX);
		print("The lowest number you can pick is " + MIN);

		nextGuess();
		printQuestion();
		print("Press UP arrow for higher, DOWN arrow for lower, ENTER for equal");
	}

	void Update() {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			nextGuess();
			printQuestion();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			nextGuess();
			printQuestion();
		}

		if (Input.GetKeyDown(KeyCode.Return)) {
			printAnswer();
		}
	}

	private void nextGuess() {
		int previousGuess = guess;
		for (int i = 0; i < max - min; i++) {
			int nextGuess = Mathf.FloorToInt(Random.Range(min, max + 1));
			if (previousGuess != nextGuess) {
				guess = nextGuess;
				return;
			}
		}
		printAnswer();
	}

	private void printQuestion() {
		print("Is the number higher [↑] or lower [↓] than " + guess + "? Maybe it is equal [⏎]?");
	}

	private void printAnswer() {
		print("You picked " + guess);
		Start();
	}
}

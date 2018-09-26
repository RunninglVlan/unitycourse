using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField]
    Text textComponent;
    [SerializeField]
    State startingState;

    State state;

    void Start()
    {
        state = startingState;
        textComponent.text = state.getStoryText();
    }

    void Update()
    {
        manageState();
    }

    private void manageState()
    {
        var nextStates = state.getNextStates();
        for (int index = 0; index < nextStates.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextStates[index];
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            state = startingState;
        }

        textComponent.text = state.getStoryText();
    }
}

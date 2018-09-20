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

    Dictionary<int, KeyCode> indexKeys = new Dictionary<int, KeyCode> {
        { 0, KeyCode.Alpha1 },
        { 1, KeyCode.Alpha2 }
    };

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
        for (int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(indexKeys[i]))
            {
                state = nextStates[i];
                textComponent.text = state.getStoryText();
            }
        }
    }
}

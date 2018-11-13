using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Image textBackground;
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    void Start()
    {
        setState(startingState);
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
                setState(nextStates[index]);
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            setState(startingState);
        }
    }

    void setState(State state)
    {
        this.state = state;
        Color color;
        ColorUtility.TryParseHtmlString(state.getColor(), out color);
        textBackground.color = color;
        textComponent.text = state.getStoryText();
    }
}

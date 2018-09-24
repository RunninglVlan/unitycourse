using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{

    [TextArea(3, 13)]
    [SerializeField]
    string storyText;

    [SerializeField]
    State[] nextStates;

    public string getStoryText()
    {
        return storyText;
    }

    public State[] getNextStates()
    {
        return nextStates;
    }
}

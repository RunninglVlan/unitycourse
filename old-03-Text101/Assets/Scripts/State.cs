using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    private Dictionary<Tag, string> stateColors = new Dictionary<Tag, string> {
        { Tag.Intro,    "#733702" },
        { Tag.Story,    "#0095B3" },
        { Tag.GameOver, "#800000" },
        { Tag.Success,  "#2B8100" }
    };

    [TextArea(4, 14)]
    [SerializeField] string storyText;

    [SerializeField] State[] nextStates;

    [SerializeField] Tag tag = Tag.Story;

    public string getStoryText() => storyText;

    public State[] getNextStates() => nextStates;

    public string getColor() => stateColors[tag];

    private enum Tag { Intro, Story, GameOver, Success }
}

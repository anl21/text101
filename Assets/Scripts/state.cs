using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "state")]

public class state : ScriptableObject
{
    [TextArea(14,10)][SerializeField] string StoryText;
    [SerializeField] state[] nextStates;
    public string GetStateStory()
    {
        return StoryText;

    }

    public state[] GetNextStates()
    {
        return nextStates;
    }
}

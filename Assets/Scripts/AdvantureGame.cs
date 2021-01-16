using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdvantureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] state startingState;

    state state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[2];
        }
        textComponent.text = state.GetStateStory();
    }
}

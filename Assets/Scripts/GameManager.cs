using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text txtComponent;
    [SerializeField] State startingState;

    State state;

    void Start() {
        state = startingState;
        txtComponent.text = state.GetStateStory();
    }

    void Update() {
        ChangeState();
    }

    void ChangeState() {
        var nextState  = state.GetNextStates();
        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            state = nextState[0];
        }else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            state = nextState[1];
        }

        txtComponent.text = state.GetStateStory();
    }
}

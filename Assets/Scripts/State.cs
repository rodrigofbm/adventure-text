using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {
    [TextArea(14,10)] [SerializeField] string storyTxt;
    [SerializeField] State[] nextStates;

    public string GetStateStory() {
        return storyTxt;
    }

    public State[] GetNextStates() {
        return nextStates;
    }
}

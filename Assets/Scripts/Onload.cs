using UnityEngine;
using UnityEngine.Events;

public class Onload : MonoBehaviour {
    public UnityEvent action;

    private void Start() {
        action.Invoke();
    }
}
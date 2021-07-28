using UnityEngine;

public class EndOfQuest : MonoBehaviour {
    public BoolObject theEnd;

    public void End() {
        theEnd.boolean = true;
    }
}
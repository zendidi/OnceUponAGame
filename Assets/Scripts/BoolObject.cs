using UnityEngine;

[CreateAssetMenu(fileName = "BoolObject", menuName = "Son chaperon est rouge/BoolObject", order = 0)]
public class BoolObject : ScriptableObject {
    public bool boolean;

    public void set(bool value){
        boolean = value;
    }
}
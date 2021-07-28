using UnityEngine;

[CreateAssetMenu(fileName = "FloatObject", menuName = "Son chaperon est rouge/IntObject", order = 0)]
public class FloatObject : ScriptableObject {
    public float number;

    public void set(float value){
        number = value;
    }
}
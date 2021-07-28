using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Personnage", menuName = "Son chaperon est rouge/Personage", order = 0)]
public class Personnage : ScriptableObject {
    public string nom;
    public Sprite Icon;    
}
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Phrases
{
    public Personnage personnage;

    [TextArea(3,10)]
    public string phrases;

    public UnityEvent Action;
}
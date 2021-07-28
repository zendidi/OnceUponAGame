using UnityEngine;
using UnityEngine.UI;

public class ObjectifManager : MonoBehaviour {
    private string currentObjectif;
    public Text textObjectif;

    public void ChangerObjectif(string objectif){
        currentObjectif = objectif;
        textObjectif.text = currentObjectif;
    }

}
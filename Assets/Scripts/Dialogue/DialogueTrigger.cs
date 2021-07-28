using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Events;

public class DialogueTrigger : MonoBehaviour {

    public Items require = null;

    public Phrases[] dialogue;
    public UnityEvent actionEndDialogue;


    public void TriggerDialog(){
        if(FindObjectOfType<InventoryManager>().InventoryLenght() == 0 && require == null){
            FindObjectOfType<DialogManager>().StartDialogue(dialogue, actionEndDialogue);
            gameObject.SetActive(false);
        }else if(FindObjectOfType<InventoryManager>().FindITem(require)){
            FindObjectOfType<DialogManager>().StartDialogue(dialogue, actionEndDialogue);
            gameObject.SetActive(false);
        }
    }
    
    private void OnTriggerEnter(Collider other) {
        TriggerDialog();
    }
}
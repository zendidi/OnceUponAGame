using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class DialogueOnLoad : MonoBehaviour {

    public InventoryManager inventoryManager;
    public DialogManager dialogManager;
    public Items require = null;

    public Phrases[] dialogue;

    public UnityEvent actionEndDialogue;

    public void TriggerDialog(){
        if(inventoryManager.InventoryLenght() == 0 && require == null){
            dialogManager.StartDialogue(dialogue, actionEndDialogue);
            gameObject.SetActive(false);
        }else if(inventoryManager.FindITem(require)){
            dialogManager.StartDialogue(dialogue, actionEndDialogue);
            gameObject.SetActive(false);
        }
    }

    private void Start() {
        TriggerDialog();
    }

}
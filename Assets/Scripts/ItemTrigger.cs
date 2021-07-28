using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemTrigger : MonoBehaviour
{
    public Items currentItem;

    public UnityEvent Action;

    public GameObject particule;

    private void OnTriggerEnter(Collider other) {
        if(particule != null){
            GameObject part =  Instantiate(particule, transform.position, transform.rotation);
            part.GetComponent<ParticleSystem>().Play();
        }
        TriggerInventory();
        Action.Invoke();
    }

    void TriggerInventory(){
        FindObjectOfType<InventoryManager>().AddItem(currentItem);
        gameObject.SetActive(false);
    }
}

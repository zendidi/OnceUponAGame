using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarterManager : MonoBehaviour
{
    public GameObject[] items;
    
    private void OnDisable() {
        foreach (GameObject item in items)
        {
            item.GetComponent<Collider>().isTrigger = false;
        }
    }
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour {
    
    public List<Items> Inventory;

    private void Start() {
        Inventory = new List<Items>();
    }

    public void AddItem(Items newItem){
        Inventory.Add(newItem);
    }

    public int InventoryLenght(){
        return Inventory.Count; 
    }

    public bool FindITem(Items item){
        return Inventory.Exists(e => e.Equals(item));
    }
}
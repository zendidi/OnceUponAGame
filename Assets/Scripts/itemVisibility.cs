using UnityEngine;

public class itemVisibility : MonoBehaviour {

    private Collider _collider;

    private void Start() {
        _collider = GetComponent<Collider>();
        _collider.isTrigger = false;
    }

    public void Active(){
        _collider.isTrigger = true;
    }
}
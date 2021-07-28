using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsoMainCamera : MonoBehaviour
{
    public Vector3 Offset;

    private GameObject player;

    private void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Start() {
    }

    private void FixedUpdate() {
        transform.position = player.transform.position + Offset;
        transform.LookAt(player.transform);
        Debug.DrawLine(transform.position, transform.forward);
    }

}

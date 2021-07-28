using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAt : MonoBehaviour
{
    public void LookAtPlayer()
    {
        gameObject.transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform);
    }
}

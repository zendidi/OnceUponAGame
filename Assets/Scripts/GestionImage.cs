using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestionImage : MonoBehaviour
{
    public Image IEUF;

    // Start is called before the first frame update
    void Start()
    {
        IEUF.CrossFadeAlpha(0, 2, false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutoScript : MonoBehaviour
{
    public Image TutoAll;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TutoAll.CrossFadeAlpha(0, 0.5f, false);
        }
    }
}

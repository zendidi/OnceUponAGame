using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class credits : MonoBehaviour
{
    public Image Credits;
    public Image CreditsLudus;
    public Image CreditsKenney;
    
    // Start is called before the first frame update
    void Start()
    {
        Credits.canvasRenderer.SetAlpha(0.0f);
        CreditsLudus.canvasRenderer.SetAlpha(0.0f);
        CreditsKenney.canvasRenderer.SetAlpha(0.0f);
        


        Invoke("fadeCreditsLudus", 1);
        Invoke("fadeOutCreditsLudus", 3);
        Invoke("fadeCreditsKenney", 4);
        Invoke("fadeOutCreditsKenney", 6);
        Invoke("fadeCredits", 7);
        Invoke("fadeOutCredits", 9);
        Invoke("IrokiGoto", 10);
    }

    void Update()
    {
        
    }

    void fadeCreditsLudus() { CreditsLudus.CrossFadeAlpha(1, 1, false); }
    void fadeCreditsKenney() { CreditsKenney.CrossFadeAlpha(1, 1, false); }
    void fadeCredits() { Credits.CrossFadeAlpha(1, 1, false); }
    void fadeOutCreditsLudus() { CreditsLudus.CrossFadeAlpha(0, 1, false); }
    void fadeOutCreditsKenney() { CreditsKenney.CrossFadeAlpha(0, 1, false); }
    void fadeOutCredits() { Credits.CrossFadeAlpha(0, 1, false); }
    void IrokiGoto() { SceneManager.LoadScene("Menu_3d"); }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public Image choixjouer;
    public Image choixTuto;
    public Image choixCredits;
    public Image choixQuitter;

    public Camera mainCamera;

    Vector3 camPositionJouer = new Vector3(600.5f, 6.3f, 45f);
    Vector3 camPositionTuto = new Vector3(651f, 6.3f, 10f);
    Vector3 camPositionCredits = new Vector3(524f,6.3f,192f);
    Vector3 camPositionQuitter = new Vector3(620f,6.3f,129f);


    public Image TutoAll;

    public Image IEUF;
    int choix = 0;

    // Start is called before the first frame update
    void Start()
    {
        IEUF.canvasRenderer.SetAlpha(0.0f);
        TutoAll.canvasRenderer.SetAlpha(0.0f);

        mainCamera.transform.position = camPositionJouer;

        choixjouer.canvasRenderer.SetAlpha(0.5f);
        choixTuto.canvasRenderer.SetAlpha(0.5f);
        choixCredits.canvasRenderer.SetAlpha(0.5f);
        choixQuitter.canvasRenderer.SetAlpha(0.5f);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            choix--;
            if (choix == -1)
            {
                choix = 3;
            }
            Debug.Log(choix);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            choix++;
            if (choix == 4)
            {
                choix = 0;
            }
            Debug.Log(choix);
        }

        Vector3 camTempPos = mainCamera.transform.position;
        switch (choix)
        {
            
            case 0:
                choixjouer.canvasRenderer.SetAlpha(1.0f);
                choixTuto.canvasRenderer.SetAlpha(0.5f);
                choixCredits.canvasRenderer.SetAlpha(0.5f);
                choixQuitter.canvasRenderer.SetAlpha(0.5f);
                mainCamera.transform.position = Vector3.Lerp(camTempPos, camPositionJouer, 2);
                break;

            case 1:
                choixjouer.canvasRenderer.SetAlpha(0.5f);
                choixTuto.canvasRenderer.SetAlpha(1.0f);
                choixCredits.canvasRenderer.SetAlpha(0.5f);
                choixQuitter.canvasRenderer.SetAlpha(0.5f);
                mainCamera.transform.position = Vector3.Lerp(camTempPos, camPositionTuto, 2);
                break;

            case 2:
                choixjouer.canvasRenderer.SetAlpha(0.5f);
                choixTuto.canvasRenderer.SetAlpha(0.5f);
                choixCredits.canvasRenderer.SetAlpha(1.0f);
                choixQuitter.canvasRenderer.SetAlpha(0.5f);
                mainCamera.transform.position = Vector3.Lerp(camTempPos, camPositionCredits, 2);
                break;

            case 3:
                choixjouer.canvasRenderer.SetAlpha(0.5f);
                choixTuto.canvasRenderer.SetAlpha(0.5f);
                choixCredits.canvasRenderer.SetAlpha(0.5f);
                choixQuitter.canvasRenderer.SetAlpha(1.0f);
                mainCamera.transform.position = Vector3.Lerp(camTempPos, camPositionQuitter, 2);
                break;
        }

        if (Input.GetButtonDown("Submit"))
        {
            switch (choix)
            {

                case 0:
                    if (Input.GetButtonDown("Submit"))
                    {
                        IEUF.CrossFadeAlpha(1, 2, false);
                    }
                    break;

                case 1:
                    if (Input.GetButtonDown("Submit"))
                    {
                        TutoAll.CrossFadeAlpha(1, 0.5f, false);
                    }
                    break;

                case 2:
                    if (Input.GetButtonDown("Submit"))
                    {
                        SceneManager.LoadScene("CreditsDebut");
                    }
                    break;

                case 3:
                    if (Input.GetButtonDown("Submit"))
                    {
                        Application.Quit();
                        Debug.Log("QUIT");
                    }
                    break;
            }
        }


        if (IEUF.canvasRenderer.GetAlpha() == 1)
        {
            SceneManager.LoadScene("MaisonChaperon");
        }

    }

}

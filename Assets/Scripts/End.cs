using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    private int hashIsEnd;
    private Animator animator;

    private void Start() {
        Debug.Log(gameObject);
        Debug.Log("STAAAART");
        animator = GetComponent<Animator>();
        hashIsEnd = Animator.StringToHash("IsEnd");
        Debug.Log("start : "+animator);
    }

    public void StartEnd(){
        Debug.Log("GET : "+GetComponent<Animator>());
        Debug.Log("anim : "+animator);
        Debug.Log("hash : "+hashIsEnd);
        animator.SetBool(hashIsEnd, true);
    }

    private void Update() {
        if(animator.GetBool(hashIsEnd)){
            if(Input.GetButtonDown("Submit")){
                StartCoroutine(LoadAsyncScene("Menu_3d"));
            }
        }
    }

    private IEnumerator LoadAsyncScene(string name){
        
        yield return new WaitForSeconds(1);

        AsyncOperation async = SceneManager.LoadSceneAsync(name);

        while(!async.isDone){
            yield return null;
        }

    }

}

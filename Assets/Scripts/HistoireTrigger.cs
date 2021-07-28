using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class HistoireTrigger : MonoBehaviour
{
    public Items histoire1;
    public string nomSceneHistoire1;
    public Items histoire2;
    public string nomSceneHistoire2;

    public Items histoire3;
    public string nomSceneHistoire3;

    public UnityEvent action;


    private void OnTriggerEnter(Collider other) {
        
        if(FindObjectOfType<InventoryManager>().FindITem(histoire1)){
            action.Invoke();
            StartCoroutine(LoadAsyncScene(nomSceneHistoire1));
        } else if (FindObjectOfType<InventoryManager>().FindITem(histoire2)){
            action.Invoke();
            StartCoroutine(LoadAsyncScene(nomSceneHistoire2));
        } else if (FindObjectOfType<InventoryManager>().FindITem(histoire3)){
            action.Invoke();
            StartCoroutine(LoadAsyncScene(nomSceneHistoire3));
        } else
        {
            return;
        }

    }

    private IEnumerator LoadAsyncScene(string name){
        

        AsyncOperation async = SceneManager.LoadSceneAsync(name);

        while(!async.isDone){
            yield return null;
        }

    }
}

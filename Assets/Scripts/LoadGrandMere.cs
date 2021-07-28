using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class LoadGrandMere : MonoBehaviour {
    public BoolObject theEnd;
    public string sceneToLoad;
    public UnityEvent action;

    private void OnTriggerEnter(Collider other) {
        if(theEnd.boolean){
            action.Invoke();
            StartCoroutine(LoadAsyncScene(sceneToLoad));
        }
    }

    private IEnumerator LoadAsyncScene(string name){
    
    AsyncOperation async = SceneManager.LoadSceneAsync(name);

    while(!async.isDone){
        yield return null;
    }

}
}
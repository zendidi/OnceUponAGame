using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScene : MonoBehaviour
{
    public BoolObject isloading;

    private Animator animator;
    private int hashIsLoading;

    private void Start() {
        animator = GetComponent<Animator>();
        hashIsLoading = Animator.StringToHash("IsLoading");
    }
    private void Update() {
        if(!isloading.boolean){
            animator.SetBool(hashIsLoading, true);
        } else if(isloading.boolean){
            animator.SetBool(hashIsLoading, false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public FloatObject speed;

    private Vector3 forward;
    private Vector3 right;

    private Rigidbody rb;
    public Vector3 forwardMove;

    private Animator animator;
    private int hashIsMove;


    private void Awake() {
        rb = GetComponent<Rigidbody>();

        animator = GetComponent<Animator>();
        hashIsMove = Animator.StringToHash("IsMove");

    }

    void FixedUpdate() {
        forward = Camera.main.transform.forward;
        forward.y = 0;

        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
        float horizontal = 0;
        float vertical = 0;
        if(Input.GetKey(KeyCode.LeftArrow)){
            horizontal = -1;
        } else if( Input.GetKey(KeyCode.RightArrow)){
            horizontal = 1;
        }

        if(Input.GetKey(KeyCode.UpArrow)){
            vertical = 1;
        } else if(Input.GetKey(KeyCode.DownArrow)){
            vertical = -1;
        }

        Vector3 rightMovement = right * horizontal;
        Vector3 upMovement = forward * vertical;

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        rb.AddForce(heading * speed.number);

        if(heading != Vector3.zero)
        {
            animator.SetBool(hashIsMove, true);
            transform.forward = heading;
        } else{
            animator.SetBool(hashIsMove, false);
        }


        ciao();

    }

    public void ciao()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericPlayerScript : MonoBehaviour
{
    public GameObject enemy;
    public Vector3 focusPoint;
    protected Animator animator; 

    // Start is called before the first frame update
    void OnEnable()
    {
        focusPoint = enemy.transform.position;
        animator = GetComponent<Animator>();

    }

    void FixedUpdate()
    {
        focusPoint = enemy.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        TurnTowardsFocus();
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if(animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                animator.SetTrigger("ForwardTrigger");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                animator.SetTrigger("RightTrigger");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                animator.SetTrigger("LeftTrigger");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                animator.SetTrigger("BackTrigger");
        }

    }

    void TurnTowardsFocus()
    {
        //transform.LookAt(focusPoint);
    }

    void ClearAllTriggers()
    {
        for(int i=0; i<animator.parameterCount;i++)
        {
            animator.ResetTrigger(i);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrafeLeftScript : StateMachineBehaviour
{
    public GenericPlayerScript parentScript;
    Transform tempTransform;
    float degree;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        parentScript = animator.gameObject.GetComponent<GenericPlayerScript>();
        tempTransform = animator.gameObject.GetComponent<Transform>();
        degree = 6f / Vector3.Distance(tempTransform.position, parentScript.focusPoint);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        tempTransform.Translate(new Vector3(-0.1047f, 0f, 0f));
        tempTransform.Rotate(new Vector3(0f, degree, 0f));
        //tempTransform.LookAt(parentScript.focusPoint);
        animator.rootPosition = tempTransform.position;
        animator.rootRotation = tempTransform.rotation;
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}

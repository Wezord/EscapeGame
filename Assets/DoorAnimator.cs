using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DoorAnimator : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        DoorManager.current.onDoorOpen += onStepOne;
    }

    void onStepOne(Boolean isOpen){
        if(isOpen){
            animator.SetBool("isOpen", true);
        }
        else {
            animator.SetBool("isOpen", false);
        }
    }
}

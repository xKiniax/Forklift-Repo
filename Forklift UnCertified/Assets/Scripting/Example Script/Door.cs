using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IActivatable
{

    private Animator animator;

    public int requiredTriggers = 1;
    public int activeCount = 0;

    void Start()
    {
     
        animator = GetComponent<Animator>();

    }

    public void Activate()
    {

        activeCount++;

        if(activeCount >= requiredTriggers)
        {

            animator.SetBool("Open", true);

        }

    }

    public void Deactivate()
    {

        activeCount--;

        if(activeCount < 0)
            activeCount = 0;

        if (activeCount < requiredTriggers)
        {

            animator.SetBool("Open", false);

        }

    }    

}

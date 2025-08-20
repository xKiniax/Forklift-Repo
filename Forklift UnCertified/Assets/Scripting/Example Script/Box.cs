using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Box : MonoBehaviour
{

    public float weight = 1;

    public bool playerPushable = true;

    [Range(0f, 1f)] public float playerCoefficientOfRestitution = 0.2f;

    public virtual void PickUp()
    {

    }

    public virtual void PutDown()
    {

    }

    public virtual void Lift()
    {

    }   
    
    public virtual void Lower()
    {

    }
}

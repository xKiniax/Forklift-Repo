using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemGrabber : MonoBehaviour
{


    private Box curBox;
    public bool boxHeld;
    private Vector3 boxOfset = new();

    private void OnTriggerStay(Collider other)
    {
        
        if(!boxHeld && other.gameObject.TryGetComponent<Box>(out Box box))
            curBox = box;

    }

    private void OnTriggerExit(Collider other)
    {
        
        if(!boxHeld)
            curBox = null;

    }

    private void FixedUpdate()
    {
        
        //if(boxHeld)
        //    curBox.transform.localPosition = boxOfset;

    }

    public void GrabBox()
    {

        if (curBox == null)
            return;

        curBox.transform.parent = transform.GetChild(0);
        boxOfset = curBox.transform.localPosition;

        Destroy(curBox.GetComponent<Rigidbody>());

        

        boxHeld = true;

    }

    public void ReleaseBox()
    {

        if (!boxHeld)
            return;

        curBox.AddComponent<Rigidbody>();
        curBox.transform.parent = null;

        boxHeld = false;

    }


}

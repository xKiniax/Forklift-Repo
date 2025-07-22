using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVector2 : MonoBehaviour
{
    public float x, y;

    //properties
    //Magnitude
    //SquareMagnitude
    //Angle from x-axis
    //Angle from y-axis

    // a^2 + b^2 = c^2
    // Magnitude = Mathf.sqrt(x^2 + y^2 + z^2) //for vector3

    //Debug.Log all the properties in start

    // Start is called before the first frame update
    void Start()
    {

    }

    public float SquareMagnitude
    {
        get { return x * x + y * y; }
    }

    public float Magnitude
    {
        get { Mathf.sqrt(SquareMagnitude); return Mathf.Sqrt(); }
    }

    public float AngleX
    {
        get { return Mathf.Tan(y / x); }
    }

    public float AngleY
    {
        get { return Mathf.Tan(x / y); }
    }

}

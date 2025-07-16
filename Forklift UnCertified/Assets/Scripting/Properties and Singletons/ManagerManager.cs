using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerManager : MonoBehaviour
{
    /*Singletons
    One of 'em

    Worst way of making sure I'm the only one
    - Find all of them using GameObject.FindObjsByType
    - Find some reference to the current one (paradox of Infinite Managers)
    - static thing
     */

    private static ManagerManager _instance;

    public static ManagerManager Instance
    {
        get
        {
            if(_instance != null)
            {
                return _instance;
            }
            else
            {
                GameObject managerObj = Instantiate(new GameObject());
                _instance = managerObj.AddComponent<ManagerManager>();
                return _instance;
            }
        }
        private set
        {
            _instance = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //This is incredibly inefficient
        ManagerManager[] Managers = FindObjectsByType<ManagerManager>(FindObjectsSortMode.None);
        if(Managers.Length > 1)
        {
            Destroy(this);
        }

        if(_instance != null)
        {
            Destroy(this);
        }
        else
        {
            _instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

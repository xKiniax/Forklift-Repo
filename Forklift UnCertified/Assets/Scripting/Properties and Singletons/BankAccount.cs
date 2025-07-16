using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankAccount : MonoBehaviour
{
    /*
     What is a property?
    Jacob: "A piece of land"
    Kate: "I mean the coding term :/"
    Erik: "I 'unno"

    Physics Property?
    A piece of information about the thing (Temperature, Tensile Strength)
     
    Coding properties
    "Accessible information about an object"
     */

    private List<float> transactions;

    public readonly int accountNumber;

    //Balance is a property
    public float Balance
    {
        get
        {
            //to get balance, add up transactions
            float bal = 0;
            for (int i = 0; i < transactions.Count; i++)
                bal += transactions[i];
            return bal;
        }
        set // if you write "Balance = value;" set happens
        {
            if (Balance == value)
                return;
            /*
             * change from 20 to 30
             * intuit, new transaction of value 10
             */
            //make a new transaction equal to the difference between old value and new value
            //the new value is called "value"
            NewTransaction(value-Balance);
        }
    }

    float _backedBalance = 0f;
    bool _backedBalanceAccurate = false;
    public float BackedBalance
    {
        get
        {
            if (_backedBalanceAccurate)
                return _backedBalance;
            else
            {
                _backedBalance = Balance;
                _backedBalanceAccurate = true;
                return _backedBalance;
            }
        }
    }

    void NewTransaction(float value)
    {
        transactions.Add(value);
        _backedBalanceAccurate = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        transactions = new();
        NewTransaction(7f);
        Debug.Log(Balance);
        Balance = 10f;
        Debug.Log(Balance);
    }

    // Update is called once per frame
    void Update()
    {
    }
}

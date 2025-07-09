using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginnerCheatSheet : MonoBehaviour
{

    public int publicNumber = 3;

    [SerializeField] int myNumber = 5;

    [SerializeField] internal int familyNumber = 8;

    public bool amIHere = false;

    public List<int> myNumbers = new();

    public struct MyInfo
    {

        public string myName;
        public int myAge;
        public float myBankAccountBalance;

    }

    public MyInfo myinfo;

    private void Awake()
    {
        return;

        amIHere = false;
    }

    // Start is called before the first frame update
    void Start()
    {

        myinfo.myAge = 26;

        Awake();

        amIHere = AmIHere();

        amIHere = myNumbers.Count != 0;

        if ((amIHere && myNumber != publicNumber) || (!amIHere)) // equal ==, not equal !=, greater than >, less than <, greater than or equal >=, less than or equal <=,
        {

            print(myNumber.ToString());

        }
        else if (amIHere)
        {

        }
        else
        {

        }

        switch (familyNumber)
        {
            case (0):
            case (1):
                break;
            case (2):
            case (3):
            case (4):

                break;
            default:
                break;

        }

        for (int i = 0; i < myNumbers.Count; i++)
        {

            print(myNumbers[i].ToString());

            if (i == 2)
                break;

        }

        foreach (int number in myNumbers)
        {

            print(number.ToString());

        }


        DoMath(myNumber, myinfo.myAge);

    }

    // Update is called once per frame
    void Update()
    {



    }

    public void DoMath(int firstNumber, int secondNumber)
    {

        int newNumber = firstNumber + secondNumber;
        print(newNumber);

    }

    private void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private bool AmIHere()
    {

        if (myNumbers.Count != 0)
            return true;

        return false;

    }
}

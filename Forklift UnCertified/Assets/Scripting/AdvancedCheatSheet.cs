using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedCheatSheet : BeginnerCheatSheet
{
    private void Start()
    {

    }

    public override void DoMath(int a, int b)
    {

    }

    private void LateUpdate()
    {
        amIHere = false;
        if(this is IEdible)
        {

        }
        else if(TryGetComponent<IEdible>(out IEdible edible))
        {
            edible.Eat();
        }
    }
}

public class Banana : Collectible, IEdible
{
    public override bool Collect()
    {
        return true;
    }

    public void Eat()
    {

    }
}

public abstract class Collectible:MonoBehaviour
{
    private void OnColliderEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            Collect();
        }
    }

    public abstract bool Collect();
}

public interface IEdible
{
    public void Eat();
}
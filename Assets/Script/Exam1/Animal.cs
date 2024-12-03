using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;

    public void Init(string animalName)
    {
        Debug.Log($"This is a {animalName}");
    }

    public abstract float CalculateFoodRequirement()
    {
        
    }

    public void MakeSound()
    {
        Debug.Log($"The animal makes a sound.");
    }

    public void DisplayName(string newDisplay)
    {
        Debug.Log($"{animalName} {newDisplay}");
    
    
    }





    void Start()
    {
        
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripts : MonoBehaviour
{ int healthpoints = 3992;

    void Start()
    {
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        
        Debug.Log(healthpoints); 
    }

    void Update()
    {
       
    }

    int UsePotion(int health)
    {
        health += 400;
        return health;
    }
}
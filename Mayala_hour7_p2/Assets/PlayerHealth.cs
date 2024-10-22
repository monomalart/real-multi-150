using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{ float health = 1004f;
    float poisonDamage = 125.5f;

    void Start()
    {
        ApplyPoison();
    }

    void ApplyPoison()
    {
        Debug.Log("Initial Health: " + health);
        
        while (health > 0)
        {
            health -= poisonDamage;
            Debug.Log("Health after poison: " + health);
        }

        if (health <= 0)
        {
            Debug.Log("Player has been unalived!");
            

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

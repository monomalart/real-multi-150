using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
  {
        for (int number = 22; number <= 100; number += 2)
        {
            Debug.Log(number);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

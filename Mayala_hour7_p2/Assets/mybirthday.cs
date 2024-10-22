using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mybirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   int birthdayDay = 13; 
        int daysInMonth = 31; 

        for (int day = 1; day <= daysInMonth; day++)
        {
            if (day == birthdayDay)
            {
                Debug.Log("It's my birthday!");
            }
            else
            {        
                Debug.Log(day);
            }
        }
    }
    void Update()
    {
        
    }
}

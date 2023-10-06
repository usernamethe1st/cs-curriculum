using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter2D(Collision2D other)
    {
        
        
            ChangeHeath(-1);
        
    }

     void ChangeHeath(int -1)
     {
         health  = health - 1;
        if (health < 1)
        {
            death()  

        }
         
     }

     void death()
     {
         this.gameObject = (0, -2.46, -2.393815);
         health = 5; 
     }
}

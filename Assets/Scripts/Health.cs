using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    public HUD hud;
    //public int health;
    public bool iframe;
    public float iframes;
    private Vector3 originalPosition;

    
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
        hud.health = 5;
        iframes = 1.5f;
        iframe = false;
        originalPosition = transform.position;
    }

    //Update is called once per frame
    void Update()
    {
        if (iframe == true)
        {
            iframes = iframes - Time.deltaTime;
        }

        if (iframes < 0)
        {
            iframes = 1.5f;
            iframe = false;
        }
        if (Time.deltaTime < 0)
        {
            iframes = 1.5f;
            iframe = false;
        }
    }

     void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        { 
            if (iframe == false)
            {
                ChangeHeath(-1);
                iframe = true;
                
            }
        }
        
        if (other.gameObject.CompareTag("Fireball"))
        { 
            if (iframe == false)
            {
                ChangeHeath(-3);
                iframe = true;
                other.gameObject.SetActive(false);
                
            }
        }
        
        if (other.gameObject.CompareTag("Potion"))
        { 
            ChangeHeath(1);
            other.gameObject.SetActive(false);
        }

    }

      void ChangeHeath(int amount)
     {
         hud.health  = hud.health + amount;
        if (hud.health < 1)
        {
            Death();

        }
        hud.health++;
     }

    void Death()
    {
        transform.position = originalPosition;
         hud.health = 5; 
         
     }
}

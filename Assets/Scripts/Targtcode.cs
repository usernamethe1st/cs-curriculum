using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Targtcode : MonoBehaviour
{
    
    public HUD hud;
    public float luck = 10f;
    public GameObject Fireball;
    public bool iframe;
    public float iframes;
    public Transform target;
    public Rigidbody2D rd ;
   
    public float rotateSpeed = 200f;
    

    // Start is called before the first frame update  
    void Start()
    {
        iframes = 1;
        iframe = false;
        
    }

     //Update is called once per frame
    void Update()
    {        if (iframe == true)
        {
            iframes = iframes - Time.deltaTime;
        }
        if (iframes < 0)
        {
            Instantiate(Fireball,transform.position,transform.rotation);
            iframes = 1;
            iframe = false;
        }


        if (iframe == false)
        {
            
          
        }
    }

    //void OnCollisionEnter2D(Collision2D other)

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           iframe = true;

           
           
        }                                    
    }
}

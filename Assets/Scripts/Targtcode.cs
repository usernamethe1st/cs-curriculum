using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targtcode : MonoBehaviour
{
    public float thrust = 1.1f;
    public float must = 1.1f;
    public float luck = 1.1f;
    public GameObject Fireball;
    public bool iframe;
    public float iframes;

    public Rigidbody2D rd;
    // Start is called before the first frame update
    void Start()
    {
        iframes = 1000;
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
            iframes = 1000;
            iframe = false;
        }
        if (iframe == true)
        {
            Instantiate(Fireball);
           // Fireball.GetComponent<Rigidbody2D>();
           // rd.AddForce(luck, must, thrust, ForceMode2D.Impulse);

        }
        if (iframe == false)
        {
            
          Destroy(Fireball);
        }
   }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           iframe = true;

           
           
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Targtcode : MonoBehaviour
{
    
   
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

            Vector2 direction = (Vector2)target.position - rd.position;

            direction.Normalize();
            float rotateAmount = Vector3.Cross(direction, transform.up).z;
            rd.angularVelocity = -rotateAmount * rotateSpeed;
            rd.GetComponent<Rigidbody2D>();

            rd.velocity = transform.up * luck;
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

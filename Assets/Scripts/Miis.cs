using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Miis : MonoBehaviour
{ 
    public GameObject Fireball;
    public bool iframe;
    public float iframes;
    public float luck = 10f;


    public Transform target;
    public Rigidbody2D rd;

    public float rotateSpeed = 200f;

    // Start is called before the first frame update
    void Start ()
    {
        iframes = 10;
        iframe = true;

        rd = GetComponent<Rigidbody2D>();
       target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (iframe)
        {
            iframes = iframes - Time.deltaTime;
        }
        if (iframes < 0)
        {
            iframes = 10;
            iframe = false;
        }
  
        if (iframe == false)
        {
            
            Destroy(Fireball);
        }
        Vector2 direction = (Vector2)target.position - rd.position;

        direction.Normalize();
        float rotateAmount = Vector3.Cross(direction, transform.up).z;
        rd.angularVelocity = -rotateAmount * rotateSpeed;
       

        rd.velocity = transform.up * luck;
    }

  

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            gameObject.SetActive(false);
        }
       
    }
}
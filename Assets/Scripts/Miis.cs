using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Rigidbody2D))]
public class Miis : MonoBehaviour
{ 
    public HUD hud;
    public GameObject Fireball;
    public bool iframe;
    public float iframes;
    public float luck = 10f;

    public GameObject Player;
    public GameObject Coin7;
    public Transform target;
    public Rigidbody2D rd;

    public float rotateSpeed = 200f;

    // Start is called before the first frame update
    void Start ()
    {
        hud = GameObject.FindObjectOfType<HUD>();
        hud.health = hud.health;
        iframes = 5;
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
            iframes = 5;
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
        if (other.gameObject.CompareTag("Player") && hud.shell == false)
        {
            ChangeHeath(-3);
            Destroy(Fireball);
        }
       
    }
   void ChangeHeath(int amount)
   {
       hud.health  = hud.health + amount;

   }

}
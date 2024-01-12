using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Orcmove : MonoBehaviour
{
    public HUD hud;
    public GameObject Orc;
    public GameObject AxeItem;
    public bool iframe;
    public float iframes;
    public float luck = 5f;

    public float random = 1;
    public float ehealth= 2;
    public GameObject Player;
    public GameObject Coin7;
    public Transform target;
    public Rigidbody2D rd;
    public GameObject Potion;
    public float rotateSpeed = 200f;

    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
        hud.health = hud.health;
        iframes = 5;
        iframe = false;

        rd = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        random = random + 1;
        if (iframe)
        {
            iframes = iframes - Time.deltaTime;
        }

        if (iframes < 0)
        {
            iframes = 5;
            iframe = false;
        }
        if (iframes == 5)
        {
            
            iframe = false;
        }



        Vector2 direction = (Vector2)target.position - rd.position;

        direction.Normalize();
        float rotateAmount = Vector3.Cross(direction, transform.up).z;
        rd.angularVelocity = -rotateAmount * rotateSpeed;


        rd.velocity = transform.up * luck;
        if (ehealth <= 0)
        {
            if (random == 3)
            {
                Instantiate(Coin7, transform.position, transform.rotation);
            }
            if (random == 1)
            {
                Instantiate(Potion, transform.position, transform.rotation);
            }   
            if (random == 2)
            {
                Instantiate(AxeItem, transform.position, transform.rotation);
            }

             Destroy(Orc);
        }

        if (random >= 4)
        {
            random = 1; 
        }
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && !iframe && hud.shell == false)
        {
            ChangeHeath(-2);
            iframe = true;
            luck = 0;
        }
        if (other.gameObject.CompareTag("Arrow") && !iframe)
        {
            Changeeheath(-2);
           
        }
    }
   
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            luck = 5f;
        }
        throw new NotImplementedException();
    }

    void ChangeHeath(int amount)
    {
        hud.health  = hud.health + amount;

    }
    void Changeeheath(int amount)
    {
        ehealth = ehealth + amount;

    }

}
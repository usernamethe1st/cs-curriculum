using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iframes : MonoBehaviour
{
    public int health;
    public bool iframe;
    public float iframes;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        iframes = 1.5f;
        iframe = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (iframe = true)
        {
            iframes = iframes - Time.deltaTime;
        }

        if (Time.deltaTime < 0)
        {
            iframes = 1.5f;
            iframe = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (iframe = false)
        {
            iframe = true;
           health  = health - 1;
        }
    }

    void ChangeHeath(int -1f)
    { 
        if (iframe = false)
        {

            iframe = true;
            health  = health - 1;
        }
    }
    void death()
    {
        this.gameObject = (0, -2.46, -2.393815);
        health = 5; 
    }
}

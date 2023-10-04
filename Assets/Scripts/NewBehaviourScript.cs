using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int health;

    public float iframes;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
       iframes = 1.5
       iframes = false
    }

    // Update is called once per frame
    void Update()
    {
        if (iframes)
        {
            iframes =  iframes - Time.DeltaTime
        }

        if (Time.DeltaTime < 1)
        {
            iframes = 1.5
            iframes = false
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (iframes)
        {
           iframes = true
           health  = health - 1;
        }
    }

    void ChangeHeath(int -1)
    {
        if (iframes)
        {
            iframes = true
            health  = health - 1;
        }
    }
    void death()
    {
        GameObject = (0, -2.46, -2.393815);
        health = 5; 
    }
}

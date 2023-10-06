using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itimes : MonoBehaviour
{
    public float timer;
    public float originaltimer = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        timer = originaltimer;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer < 0)
        {
            
        }

    }

 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itimes : MonoBehaviour
{
    private float timer;
    private float originaltimer = 1.5;
    // Start is called before the first frame update
    void Start()
    {
        timer = originaltimer;

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.DeltaTime;
        if (timer < 0)
        {
            
        }

    }

 
}

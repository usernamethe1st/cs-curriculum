using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{  
    public HUD hud;

    public float xspeed;
    public float xdir;
    public float xvector;
    public float yspeed;
    public float ydir;
    public float yvector;
    public bool overworld;
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();

        xspeed = 5f;
        if (overworld)
        {
            yspeed = 5f;
        }
        else
        {
            yspeed = 0f;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HUD.shell)
        {
            xdir = Input.GetAxis("Horizontal");
            xvector = xdir * xspeed * Time.deltaTime;


            ydir = Input.GetAxis("Vertical");
            yvector = ydir * yspeed * Time.deltaTime;
            transform.position = transform.position + new Vector3(xvector, yvector, 0);
        }
    }
}

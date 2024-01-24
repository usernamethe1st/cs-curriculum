using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platformerplayermover : MonoBehaviour
{

    public float xspeed;
    public float xdir;
    public float xvector;
    public float yspeed;
    public float ydir;
    public float yvector;
    
    public bool overworld;
    
    
    public Rigidbody2D rd;
    
    public float jumpfores = 7;
   
    public float iframe = 2;
    
    public bool inair = false;
    public bool sec = false;


    public Vector3 originarotate;
    // Start is called before the first frame update
    void Start()
    {
 
        rd = GetComponent<Rigidbody2D>();
        
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
        if (Input.GetKeyDown(KeyCode.W) && !inair )
        {
         
            Debug.Log("W key is pressed.");
            

            
            sec = true;
           
        }

        if (sec)
        {
            transform.Translate(Vector3.up * jumpfores * Time.deltaTime);
            Debug.Log("jumping");
            //  transform.Translate(Vector3.right * jumpfors * Time.deltaTime);
            //transform.Translate(Vector3.right + jumpfores + Time.deltaTime);
            //transform.Translate(Vector3.left * jumpfores * Time.deltaTime);
            //rd.AddForce(-Vector2.up,  ForceMode2D.Impulse);
            iframe = iframe - Time.deltaTime;
            inair = true;

        }else
        {
            inair = false;
        }

        if (iframe <= 0)
        {
            sec = false;
            inair = false;
            iframe = 3;
        }

        
        xdir = Input.GetAxis("Horizontal");
        xvector = xdir * xspeed * Time.deltaTime;


        ydir = Input.GetAxis("Vertical");
        yvector = ydir * yspeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xvector, yvector, 0);
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Square"))
        {
            
           inair = false;
          sec = false;

        }


    }
}



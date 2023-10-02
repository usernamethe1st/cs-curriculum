using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    
    public float walkingSpeed ;
    public float Xdir ;
    public float Xvector ;
    
    // Start is called before the first frame update
    void Start()
    { 
        walkingSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Xdir = Input.GetAxis("Horizontal");
        Xvector = Xdir * walkingSpeed*Time.deltaTime;
        transform.position = transform.position + new Vector3(Xvector,0,0);
    }
}

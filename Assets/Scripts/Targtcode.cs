//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Targtcode : MonoBehaviour
//{
 //   public GameObject Fireball;
  //  public bool iframe;
  //  public float iframes;
    // Start is called before the first frame update
   // void Start()
   // {
    //    iframes = 1000;
     //   iframe = false;


   // }

    // Update is called once per frame
    //void Update()
   // {        if (iframe == true)
       // {
        //    iframes = iframes - Time.deltaTime;
       // }
    //    if (iframes < 0)
       // {
      //      iframes = 1000;
       //     iframe = false;
      //  }
   //     if (iframe == true)
        //{
       //     Instantiate(Fireball);
            //Fireball.GetComponent<Rigidbody2D>().AddForce();

        //}
       // if (iframe == false)
        //{
            
      //    Destroy(Fireball);
       // }
   // }

   // private void OnTriggerEnter2D(Collider2D other)
    //{
      //  if (other.gameObject.CompareTag("Player"))
      //  {
      //      iframe = true;
//
      //  }
    //}
//}

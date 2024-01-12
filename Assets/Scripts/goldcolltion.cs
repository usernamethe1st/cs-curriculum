using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goldcolltion : MonoBehaviour
{
    public float ll;
    public GameObject Arrows;
    //public GameObject prefab;
   
    public bool mose ;
    public bool mm;
    public Transform target;
    public GameObject Bow;
  //  public int gold;
  public HUD hud;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        ll = 5;
        hud = GameObject.FindObjectOfType<HUD>();
        //nodus
        mose = false;
        //ds
        mm = true;
    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        //GoldText.text=("Gold "gold);
        if (mm == false)
        {
            ll = ll - Time.deltaTime;
            if (ll <= 0)
            {
                ll = 5;
                mm = true;
            }
        }

        if (mm == true)
        {

            if (Input.GetKey(KeyCode.G))
            {
                hud.shell = true;

            }
        }

        if (mose == true && mm == true)
        {
            if (Input.GetKey(KeyCode.H))
            {
                hud.luck = 0;
                Instantiate(Arrows, target.position, target.rotation);
                mm = false;
                Debug.Log("0 key is pressed.");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
  
     
        if (other.gameObject.CompareTag(("Coin")))
        {
            CollentCoin(1);
            other.gameObject.SetActive(false);
            Debug.Log("Gold: " +hud.gold);
        }
        
        //nodus
        if (other.gameObject.CompareTag("Bow"))
       {
           Debug.Log("0 key is pressed.");
            Destroy(Bow);
            other.gameObject.SetActive(false);
            mose = true;
        }
        //ds
    }

    void CollentCoin(int amount)
    {
        hud.gold = hud.gold + amount;
        hud.gold++;
    }
    

}

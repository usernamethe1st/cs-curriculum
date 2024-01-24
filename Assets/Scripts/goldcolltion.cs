using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goldcolltion : MonoBehaviour
{
    public float ll;
    public float lll;
    public float llll;
    public GameObject Arrows;
    //public GameObject prefab;
    public bool lose = false;
    public bool mose ;
    public bool mm;
    public bool mmm = true;
    public bool mmmm = true;
    public Transform target;
    public GameObject Bow;
    public GameObject AxeItem;
  //  public int gold;
  public HUD hud;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        ll = 5;
        lll = 6;
        llll = 2;
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
        
        if (mmm == false)
        {
            lll = lll - Time.deltaTime;
            if (lll <= 0)
            {
                lll = 6;
                mmm = true;
            }
        }
        
        if (mmmm == false)
        {
            llll = llll - Time.deltaTime;
            if (llll <= 0)
            {
                llll = 5;
                mmmm = true;
            }
        }

        if (mmmm == true)
        {

            if (Input.GetKey(KeyCode.H))
            {
                hud.shell = true;

                mmmm = false;
                Debug.Log("H key is pressed.");
            }
        }

        if (lose == true && mmm == true)
        {
            if (Input.GetKey(KeyCode.J))
            {
                hud.puck = 0;
                Instantiate(AxeItem, target.position, target.rotation);
                mmm = false;
                Debug.Log("j key is pressed.");
            }
        }
        if (mose == true && mm == true)
        {
            if (Input.GetKey(KeyCode.G))
            {
                hud.luck = 0;
                Instantiate(Arrows, target.position, target.rotation);
                mm = false;
                Debug.Log("G key is pressed.");
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

        if (other.gameObject.CompareTag("Axe"))
        {
            Debug.Log(" axe was grab");
            Destroy(AxeItem);
            other.gameObject.SetActive(false);
            lose = true;
            
        }
        //ds
    }

    void CollentCoin(int amount)
    {
        hud.gold = hud.gold + amount;
        hud.gold++;
    }
    

}

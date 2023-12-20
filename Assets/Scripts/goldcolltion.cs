using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goldcolltion : MonoBehaviour
{
    public float ll;
    public GameObject Arrows;
    public bool mose;
    public bool mm;

  //  public int gold;
  public HUD hud;
    // Start is called before the first frame update
    void Start()
    {
        ll = 15;
        hud = GameObject.FindObjectOfType<HUD>();
        //nodus
        mose = false;
        //ds
        mm = true;
    }

    // Update is called once per frame
    void Update()
    {
        //GoldText.text=("Gold "gold);
        if (mm == false)
        {
            ll = ll - Time.deltaTime;
            if (ll <= 0)
            {
                ll = 15;
            }
        }
        if (ll <= 15)
        {
            mm = true;
        }

        if (mose == true && mm == true)
        {
            if (Input.GetKey(KeyCode.M))
            {
                Instantiate(Arrows, transform.position, transform.rotation);
                mm = false;
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
            Destroy(Bow);
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

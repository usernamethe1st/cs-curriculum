using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goldcolltion : MonoBehaviour
{
    public int gold;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GoldText.text=("Gold "gold);
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(("Coin")))
        {
            CollentCoin(1);
            other.gameObject.SetActive(false);
            Debug.Log("Gold: " +gold);
        }
    }

    void CollentCoin(int amount)
    {
        gold =gold + amount;
        
    }
}

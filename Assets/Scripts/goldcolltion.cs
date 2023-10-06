using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goldcolltion : MonoBehaviour
{
    private int gold;
    public int amant;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GoldText.text=("Gold "gold);
        Debug.Log("points +points");
    }

    void OntiggerEnter2D(Collider2D other)
    {
            CollentCoin(1);
        
    }

    void CollentCoin(int amant)
    {
        gold =gold + amant;
        other.GameObject.SetActive(false);
    }
}

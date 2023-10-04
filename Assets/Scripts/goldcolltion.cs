using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldcolltion : MonoBehaviour
{
    private int gold;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text=("Gold "gold);
        Debug.log("points +"points);
    }

    void OntiggerEnter2D(Collider2D other)
    {
        if()
        {
            CollentCoin(1);
        }
    }

    void CollentCoin(int amant)
    {
        gold =gold + amant;
        other.gameObject.SetActive(false);
    }
}

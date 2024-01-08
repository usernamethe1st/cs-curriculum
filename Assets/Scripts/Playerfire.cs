using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerfire : MonoBehaviour
{
    public float kk;
    public float nn = 0f;
    public GameObject Arrows;
    public float iframes = 1f;
    public float luck = 5f;
    public float rotateSpeed = 0f;

    
    public Vector2 aaaaa;
    // Start is called before the first frame update
    void Start()
    {
        aaaaa = new Vector2(transform.position.x, transform.position.y);
        kk = 5;
    }

    // Update is called once per frame
    void Update()
    {
        nn += Time.deltaTime;
        transform.position = Movement(nn);
        kk = kk - Time.deltaTime;
        if (kk <= 0)
        {
            kk = 1234212314;
            luck = 5f;


        }
            
        
    }

    private Vector2 Movement(float nn)
    {
        float x = nn * luck * transform.right.x;
        float y = nn * luck * transform.right.y;

        return new Vector2(x + aaaaa.x, y + aaaaa.y);
    }
}

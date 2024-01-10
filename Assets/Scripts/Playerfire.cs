using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playerfire : MonoBehaviour
{
    public HUD hud;
    public float kk;
    public float nn = 0f;
    public GameObject Arrows;
    public float iframes = 1f;
    
    public float rotateSpeed = 0f;

    
    public Vector2 aaaaa;
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
        aaaaa = new Vector2(transform.position.x, transform.position.y);
        kk = 5;
        hud.luck = 5;
    }

    // Update is called once per frame
    void Update()
    {
        nn += Time.deltaTime;
        transform.position = Movement(nn);
        kk = kk - Time.deltaTime;
        if (kk <= 0)
        {
            Destroy(Arrows);

        }
            
        
    }

    private Vector2 Movement(float nn)
    {
        float x = nn * hud.luck * transform.right.x;
        float y = nn * hud.luck * transform.right.y;

        hud.luck = 5; 
        return new Vector2(x + aaaaa.x, y + aaaaa.y);
    }
}

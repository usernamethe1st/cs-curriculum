using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public int health;
    public int gold;
    public static HUD hud;
    public Goldcolltion purse;
    public Health life;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI healthText;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        goldText.text = "gold =" + gold.ToString();
        healthText.text = "health =" + health.ToString();
    }

    void awake()
    {
        if(hud != null && hud != this)
        {
            Destroy(this);
        }
        else
        {
            hud = this;
            DontDestroyOnLoad(this);
        }
    }

}

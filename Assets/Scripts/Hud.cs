using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hud : MonoBehaviour
{
    public Goldcolltion purse;
    public Health life;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI healthText;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        goldText.text = "gold=" + purse.gold;
        healthText.text = "health=" + life.health;
    }


}

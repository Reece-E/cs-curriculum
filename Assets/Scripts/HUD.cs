using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;


public class HUD : MonoBehaviour
{
    private static HUD hud;
    
    public Coin coinpurse;

    //public HealthCode health;

    public TextMeshProUGUI coinText;

    public TextMeshProUGUI HealthText;
    public int coins;
    public int health;

    void Awake()
    {
        if (hud != null && hud != this)
        {
            Destroy(gameObject);
        }
        else
        {
            hud = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = coins.ToString();
        HealthText.text = health.ToString();
    }
}

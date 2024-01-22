using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Orchitbox : MonoBehaviour
{
    public Transform Orcpos;
    private float health;
    private float iframesTimer;
    private float iframesTimerDefault = 1;
    private bool iframes = false;
    private int OrcHealth;
    public GameObject Coin;
    public GameObject Potion;
    public GameObject Orc1;
    private BoxCollider2D collider;
    private int Number;

    // Start is called before the first frame update
    void Start()
    {
        iframesTimer = iframesTimerDefault;
        OrcHealth = 5;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (iframes)
        {
            iframesTimer -= Time.deltaTime;
            if (iframesTimer < 0)
            {
                iframes = false;
                //reset the timer
                iframesTimer = iframesTimerDefault;
            }
        }

        
    }
    void OnTriggerEnter2D(Collider2D other)
            {
                if (other.CompareTag("Player"))
                {
                    if (!iframes)
                    {
                        ChangeOrcHealth(-1);
                        iframes = true;
                    }
    
                    if (OrcHealth < 1)
                    {
                        Number = UnityEngine.Random.Range(1, 3);
                        Debug.Log("test");
                        if (Number == 1)
                        {
                            Instantiate(Potion, Orcpos.position, Orcpos.rotation);
                        }
                        else
                        {
                            Instantiate(Coin, Orcpos.position, Orcpos.rotation);
                        }
                        Destroy(gameObject);
                        Destroy(Orc1);
                        //Instantiate(Coin, Orcpos.position, Orcpos.rotation);
                        GetComponent<Lootbag>().InstantiateLoot(transform.position);
                    }
    
    
                }
    
                if (other.CompareTag("Fireball"))
                {
                    if (!iframes)
                    {
                        ChangeOrcHealth(-1);
                        iframes = true;
    
                    }
    
                    if (OrcHealth < 1)
                    {
                        Number = UnityEngine.Random.Range(1, 3);
                        Debug.Log("test");
                        if (Number == 1)
                        {
                            Instantiate(Potion, Orcpos.position, Orcpos.rotation);
                        }
                        else
                        {
                            Instantiate(Coin, Orcpos.position, Orcpos.rotation);
                        }

                        Destroy(gameObject);
                        Destroy(Orc1);
                        //Instantiate(Coin, Orcpos.position, Orcpos.rotation);
                        //GetComponent<Lootbag>().InstantiateLoot(transform.position);
                    }
    
    
                }
    
                if (other.CompareTag("PlayerBullet"))
                {
                    if (!iframes)
                    {
                        ChangeOrcHealth(-1);
                        iframes = true;
    
                    }
    
                    if (OrcHealth < 1)
                    {
                        Number = UnityEngine.Random.Range(1, 3);
                        Debug.Log("test");
                        if (Number == 1)
                        {
                            Instantiate(Potion, Orcpos.position, Orcpos.rotation);
                        }
                        else
                        {
                            Instantiate(Coin, Orcpos.position, Orcpos.rotation);
                        }
                        Destroy(gameObject);
                        Destroy(Orc1);
                        //Instantiate(Coin, Orcpos.position, Orcpos.rotation);
                        GetComponent<Lootbag>().InstantiateLoot(transform.position);
                    }
    
                    Destroy(other.gameObject);
                }
            }
    
            void ChangeOrcHealth(int amount)
            {
                OrcHealth += amount;
                Debug.Log("OrcHealth: " + OrcHealth);
            }
}
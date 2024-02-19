using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovintPlat : MonoBehaviour
{
    public int pSpeed;
    public int sSpeed;
    public Transform Itarget;
    public Transform dTarget;
    public Lever platformLever1;
    public bool leverStatus;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        
            if (platformLever1.leverStatus)
            {
                transform.position = Vector2.MoveTowards(transform.position, Itarget.position, pSpeed * Time.deltaTime);
            }
        

    }


    private void OnCollisionStay2D(Collision2D collision)
    {



        if (collision.gameObject.CompareTag("Player"))
        {
            transform.position = Vector2.MoveTowards(transform.position, dTarget.position, sSpeed * Time.deltaTime);
            platformLever1.leverStatus = false;

        }
        
    }

}

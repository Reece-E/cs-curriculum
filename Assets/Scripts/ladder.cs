using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    public int laderSpeed;

    public Rigidbody2D rb;

    public GameObject player; 
    // Start is called before the first frame update
    void Start()
    {
        rb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (CompareTag("Player") && Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector2.up * laderSpeed, ForceMode2D.Impulse);
        }


    }
        
    

    void Update()
    {
        
    }
}

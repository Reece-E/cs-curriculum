using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public bool leverStatus;

    private Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.CompareTag("Player"))
        {

            leverStatus = true;

            m_Animator.SetBool("Active", true);
        }
        
        
        
            



    }

    void Update()
    {
        
    }





}


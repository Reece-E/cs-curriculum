using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;


public class CamSwitch : MonoBehaviour
{
    private Animator animator;
    private bool CaveCam;

    public CinemachineVirtualCamera Vcam1; //cave
    public CinemachineVirtualCamera Vcam2; //boss
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SwitchPriority();
        }
    }

    private void SwitchPriority()
    {
        if (CaveCam)
        {
            Vcam1.Priority = 0;
            Vcam2.Priority = 1;
        }
        else
        {
            Vcam1.Priority = 1;
            Vcam2.Priority = 0;
        }

        CaveCam = !CaveCam;
    }
}

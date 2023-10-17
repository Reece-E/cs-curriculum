using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Turret : MonoBehaviour
{
   
    [SerializeField] private float scanradius = 3f;
    [SerializeField] private LayerMask layers;
    [SerializeField] private Collider2D target;
    

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, scanradius);
        
    }

    void Start()
    {
       
    }

    

    private void CheckEnviorment()
    {
        target = Physics2D.OverlapCircle(transform.position, scanradius, layers);
       
    }
    private void LookAtTarget()
    {
        if (target != null)
        {
            Vector2 direction = target.transform.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg -90f;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

    }


    // Update is called once per frame
    void Update()
    {
        CheckEnviorment();
        LookAtTarget();
        
    }
}

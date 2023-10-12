using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Turret : MonoBehaviour
{
    public GameObject player;

    public GameObject turretprojectile;

    public float initialtime;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        initialtime = timer;
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"));
        {
            timer -= Time.deltaTime;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (timer < 0);
        {
            timer = initialtime;
            GameObject projectile = Instantiate(turretprojectile, transform.position, Quaternion.identity);
             Vector3 target = player.transform.position;
             projectile.transform.Translate(target);
            
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Fireball : MonoBehaviour
{
    public float destroyDelay = 2.0f;
        
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyBullet", destroyDelay);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            DestroyBullet();
        }
            
    }
        

    public float projectileSpeed;
    // Update is called once per frame
    private void Update()
    {
            
        transform.Translate(new Vector2( projectileSpeed*Time.deltaTime,0.0f));
           
            

    }
    void DestroyBullet()
    {
        // Destroy the bullet game object
        Destroy(gameObject);
    }
}
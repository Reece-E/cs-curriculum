using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footjump : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool shouldJump;
    public bool canJump;
    
    public GameObject Player1;
    public float jumpSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = Player1.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canJump && Input.GetKeyDown(KeyCode.W))
        {

            canJump = false;
            shouldJump = true;


        }

        if (shouldJump)
        {
            rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
            shouldJump = false;
            //doublejump = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collider)
    {
        // allow jumping again
        canJump = true;
        
        
    }
    
}

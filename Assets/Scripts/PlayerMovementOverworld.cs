using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementOverworld : MonoBehaviour
{
    // Start is called before the first frame update
    private float WalkingSpeed;
    private float XDirection;
    private float XVector;
    private float YVector;
    private float YDirection;
    public Rigidbody2D rb;
    public bool shouldJump;
    public bool canJump;
    public bool Overworld;
    public GameObject Player1;
    public float jumpSpeed;
    void Start()
    {
        WalkingSpeed = 4f;
        rb = Player1.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Overworld)
        {
            XDirection = Input.GetAxis("Horizontal");
            XVector = XDirection * WalkingSpeed * Time.deltaTime;
            transform.position = transform.position + new Vector3(XVector, 0, 0);

            YDirection = Input.GetAxis("Vertical");
            YVector = YDirection * WalkingSpeed * Time.deltaTime;
            transform.position = transform.position + new Vector3(0, YVector, 0);
        }
        else
        if (canJump && Input.GetKeyDown(KeyCode.W))
        {
            canJump = false;
            shouldJump = true;
        }
            // jump
                if(shouldJump)
                {
                    rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
                    shouldJump = false;
                    //doublejump = true;
                }
                // else if (doublejump)
                // {
                //     doublejump = false;
                //      rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
                //  }
            
 
        void OnCollisionEnter2D(Collision2D collider)
        {
            // allow jumping again
            canJump = true;
            Player1.transform.tag = "onFloor";
        
        }



         void OnCollisionExit2D(Collision2D collider)
        {
            Player1.transform.tag = "Jumping";
        }
            XDirection = Input.GetAxis("Horizontal");

        XVector = XDirection * WalkingSpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(XVector, 0, 0);
        
    }
    
}


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
    public float DeploymentHeight;
    public float spriteHeight;
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
        {
            
            //canJump = Physics2D.Raycast(transform.position, Vector2.down, DeploymentHeight);


            XDirection = Input.GetAxis("Horizontal");

            XVector = XDirection * WalkingSpeed * Time.deltaTime;
            transform.position = transform.position + new Vector3(XVector, 0, 0);
            

            if ( Input.GetKeyDown(KeyCode.W) && CheckGround())
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
            // else if (doublejump)
            // {
            //     doublejump = false;
            //      rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
            //  }



        }
    }
    
    

    private bool CheckGround()
    {
 
        RaycastHit2D hit;
       
        hit = Physics2D.Raycast(transform.position, Vector2.down, DeploymentHeight);
        Debug.DrawRay(transform.position, Vector3.down * DeploymentHeight);
 
        return hit;
    }
}


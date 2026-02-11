using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables
     Rigidbody rb;
    [SerializeField] float movementspeed = 5f;
    [SerializeField] float jumpForce = 5f;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        Debug.Log("Hello World");
    }
    
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            rb.position = new Vector3(0f,5.26f,0f);
        }
        //Variables for movement

        float horizantalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //movement

        rb.velocity = new Vector3(horizantalInput * movementspeed, rb.velocity.y, verticalInput * movementspeed);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector3(rb.velocity.x,jumpForce,rb.velocity.z);
            
        }
        bool IsGrounded()
        {
            return Physics.CheckSphere(groundCheck.position, 0.2f, ground);
        }
        

       
    } 
    
    



}


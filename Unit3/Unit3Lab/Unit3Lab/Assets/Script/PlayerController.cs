using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 15f;
    [SerializeField] private float jumpForce = 500f;
    [SerializeField] private float gravity = 15f;

    private CharacterController controller;
    [SerializeField] private Vector3 moveDirection;
    [SerializeField] private bool isJumping;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        moveDirection = new Vector3(horizontalInput, 0, verticalInput);
        moveDirection *= moveSpeed;
        moveDirection.y -= gravity;

        if (Input.GetButtonDown("Sprint") && controller.isGrounded)
        {
            moveSpeed = 25f;
        }
        else
        {

        }
        
        if (Input.GetButtonDown("Jump") && controller.isGrounded) 
        {
            isJumping = true;
        } 
        else 
        {
            isJumping = false;
        }

        if (isJumping && controller.isGrounded) 
        {
            moveDirection.y = jumpForce;
            isJumping = false;
        }

        controller.Move(moveDirection * Time.deltaTime);
    }
}

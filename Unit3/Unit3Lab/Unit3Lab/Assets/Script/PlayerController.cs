using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float jumpForce = 500f;
    [SerializeField] private float gravity = 15f;

    private CharacterController controller;
    [SerializeField] private Vector3 moveDirection;
    [SerializeField] private bool isJumping;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;
    [SerializeField] private bool isCrouching;
    [SerializeField] private Vector2 faceDirection;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        faceDirection.x += Input.GetAxis("Mouse X");
        faceDirection.y += Input.GetAxis("Mouse Y");
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        moveDirection = new Vector3(horizontalInput, 0, verticalInput);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed;
        moveDirection.y -= gravity;
        transform.localRotation = Quaternion.Euler(-faceDirection.y, faceDirection.x, 0);
        if (Input.GetKeyDown(KeyCode.LeftShift) && controller.isGrounded)
        {
            moveSpeed = 25f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = 10f;
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            isCrouching = true;
            transform.localScale = new Vector3(1f,0.5f,1f);
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            isCrouching = false;
            transform.localScale = new Vector3(1f,1f,1f);
        }

        if (Input.GetButtonDown("Jump") && controller.isGrounded && isCrouching == false) 
        {
            moveDirection.y = jumpForce;
        } 

        
        controller.Move(moveDirection * Time.deltaTime);
    }
}

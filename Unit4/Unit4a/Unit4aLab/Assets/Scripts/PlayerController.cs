using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float gravity = 15f;
    [SerializeField] private Vector3 moveDirection;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;
    [SerializeField] private float xRange = 11f;
    private CharacterController controller;
   
    public GunScript gunScript;
    public PickupAmmoScript pickupAmmoScript;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        moveDirection = new Vector3(horizontalInput, 0, verticalInput);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed;
        moveDirection.y -= gravity;
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = 15f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = 5f;
        }
        controller.Move(moveDirection * Time.deltaTime);
        
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }            
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
    }
}

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
    public HealthScript healthScript;
    public PlaySoundScript playSoundScript;
    public GameManagerScript gameManagerScript;
    private bool isDead;
    public int previousHealth;
    void Start()
    {
        controller = GetComponent<CharacterController>();
        // Cursor.lockState = CursorLockMode.Locked;
        healthScript = GetComponent<HealthScript>();
        if (healthScript != null)
        {
            healthScript.maxHealth = 8;
            previousHealth = healthScript.currentHealth;
        }  
    }

    // Update is called once per frame
    void Update()
    {
        if (healthScript.currentHealth <= 0 && !isDead)
        {
            playSoundScript.StopGameSound();
            isDead = true;
            playSoundScript.PlayDeathSound();
            gameObject.SetActive(false);
            gameManagerScript.gameOver();
        }
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

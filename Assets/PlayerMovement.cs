using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed;
    public float jumpForce = 5.0f;
    public bool isOnGround = true;
    Vector3 playerPosition;
    private Rigidbody playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        // get player input 
        playerPosition.x = Input.GetAxis("Horizontal");
        playerPosition.z = Input.GetAxis("Vertical");

        playerRb.MovePosition(playerRb.position + playerPosition * speed * Time.deltaTime);

        Vector3 movementDirection = new Vector3(playerPosition.x, 0, playerPosition.z);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

        // Move the player foward


        // Let the player jump 
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}

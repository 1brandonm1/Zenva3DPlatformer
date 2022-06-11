using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed = 8f;
    public float jumpSpeed = 7f;

    // to keep our rigid body
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // get the rigidbody component for later use
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Hanlde player walking
        WalkHandler();
    }

    // Make the player walk according to user input
    void WalkHandler()
    {
        // Set x and z velocities to zero
        rb.velocity = new Vector3(0, rb.velocity.y, 0);

        // Distance (speed = distance / time --> distance = speed * time)
        float distance = walkSpeed * Time.deltaTime;

        // Input on x ("Horizontal")
        float hAxis = Input.GetAxis("Horizontal");

        // Input on z ("Vertical")
        float vAxis = Input.GetAxis("Vertical");

        // Movement vector
        Vector3 movement = new Vector3(hAxis * distance, 0f, vAxis * distance);

        // Current position
        Vector3 currPosition = transform.position;

        // New position
        Vector3 newPosition = currPosition + movement;

        // Move the rigidbody
        rb.MovePosition(newPosition);
    }
}
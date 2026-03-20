using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    Rigidbody rb;
    float movementX;
    float movementY;
    public float speed;
    public bool keyboard;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (keyboard)
        {
            Vector3 movement = new Vector3();
            movement.x = movementX;
            movement.y = 0f;
            movement.z = movementY;
            movement = movement * speed;
            rb.AddForce(movement);
        }
    }
}

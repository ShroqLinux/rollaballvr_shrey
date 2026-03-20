using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    Rigidbody rb;
    float movementX;
    float movementY;
    public float speed;
    public bool keyboard;

    public int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
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
            score += 5;
        }
        if (other.gameObject.CompareTag("Pick Up Lose"))
        {
            other.gameObject.SetActive(false);
            score -= 5;
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

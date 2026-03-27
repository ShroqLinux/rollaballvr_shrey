using UnityEngine;
using UnityEngine.InputSystem;

public class ScriptFly : MonoBehaviour
{
    public float speed = 70;
    public float pitchSpeed = 50f;
    public float rollSpeed = 50f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1. Constant forward movement
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Pitch (W = Down/Up, S = Up/Down)
        // Usually, W pitches the nose down (positive X) and S pulls it up (negative X)
        if (Keyboard.current.wKey.isPressed)
        {
            transform.Rotate(Vector3.right * pitchSpeed * Time.deltaTime);
        }
        if (Keyboard.current.sKey.isPressed)
        {
            transform.Rotate(Vector3.left * pitchSpeed * Time.deltaTime);
        }

        // Roll (A = Left, D = Right)
        if (Keyboard.current.aKey.isPressed)
        {
            transform.Rotate(Vector3.forward * rollSpeed * Time.deltaTime);
        }
        if (Keyboard.current.dKey.isPressed)
        {
            transform.Rotate(Vector3.back * rollSpeed * Time.deltaTime);
        }
    }
}

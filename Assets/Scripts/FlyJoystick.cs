using UnityEngine;
using UnityEngine.InputSystem;

public class FlyJoystick : MonoBehaviour
{
    public float speed;
    public float speedAmplifier;
    public float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Joystick.current == null)
        {
            Debug.Log("Joystick not returning any value. Reading is null");
            return;
        }

        Vector2 reading = Joystick.current.stick.ReadValue();
        float twist = Joystick.current.twist.ReadValue();
        float inputTwist = twist * Time.deltaTime;

        float roll = reading.x * - rotationSpeed;
        float pitch = reading.y * rotationSpeed;
        float yaw = inputTwist * rotationSpeed;

        this.transform.Rotate(pitch, yaw * 60, roll);

        InputControl slider = Joystick.current.allControls[15];
        float throttle = (float) slider.ReadValueAsObject();
        throttle = - throttle * speedAmplifier * Time.deltaTime;

        speed += throttle;

        // Debug.Log("Roll: " + roll + "Pitch: " + pitch + "Yaw: " + yaw + "Throttle: " + throttle);

        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}

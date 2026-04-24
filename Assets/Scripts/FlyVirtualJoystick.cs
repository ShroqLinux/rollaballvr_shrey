using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Content.Interaction;

public class FlyVirtualJoystick : MonoBehaviour
{
    public float speed;
    public float speedAmplifier;
    public float rotationSpeed;
    public XRJoystick joystick;

    public GameObject spotLight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 joystickOrientation = joystick.value;
        if (Joystick.current == null)
        {
            Debug.Log("Joystick not returning any value. Reading is null");
            return;
        }

        // float inputTwist = twist * Time.deltaTime;

        float roll = joystickOrientation.x * -rotationSpeed;
        float pitch = joystickOrientation.y * rotationSpeed;
        // float yaw = inputTwist * rotationSpeed;

        this.transform.Rotate(pitch, 0, roll);

        InputControl slider = Joystick.current.allControls[15];
        float throttle = (float)slider.ReadValueAsObject();
        throttle = -throttle * speedAmplifier * Time.deltaTime;

        speed += throttle;

        // Debug.Log("Roll: " + roll + "Pitch: " + pitch + "Yaw: " + yaw + "Throttle: " + throttle);

        this.transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Joystick.current.trigger.wasPressedThisFrame)
        {
            Debug.Log("Trigger pressed");

        }
    }
}

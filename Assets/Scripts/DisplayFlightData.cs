using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayFlightData : MonoBehaviour
{
    public TextMeshProUGUI textSpeed;
    public TextMeshProUGUI textHeight;
    public GameObject player;
    public float warningHeight;
    public GameObject warnImage;
    private FlyJoystick flyJoystick;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flyJoystick = GetComponent<FlyJoystick>();
    }

    // Update is called once per frame
    void Update()
    {
        float height = player.transform.position.y;
        string displayHeight = "Alt: " + height.ToString() + "m";
        textHeight.text = displayHeight;

        float speed = flyJoystick.speed;
        string displaySpeed = "Speed: " + speed.ToString() + "km/h";
        textSpeed.text = displaySpeed;

        if (player.transform.position.y < warningHeight) 
        {
            warnImage.SetActive(true);
        }
        else
        {
            warnImage.SetActive(false);
        }
    }
}

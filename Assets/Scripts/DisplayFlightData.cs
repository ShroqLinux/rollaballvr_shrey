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
        flyJoystick = player.GetComponent<FlyJoystick>();
    }

    // Update is called once per frame
    void Update()
    {
        float height = player.transform.position.y;
        string displayHeight = "Alt: " + height.ToString("F2") + "m";
        textHeight.text = displayHeight;

        float speed = flyJoystick.speed;
        string displaySpeed = "Speed: " + speed.ToString() + "km/h";
        textSpeed.text = displaySpeed;

        if (height > warningHeight) 
        {
            warnImage.SetActive(false);
            textHeight.color = Color.white;
        }
        else
        {
            warnImage.SetActive(true);
            textHeight.color = Color.red;
        }

        Debug.Log("Player alt: " + player.transform.position.y);
    }
}

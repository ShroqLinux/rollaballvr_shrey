using UnityEngine;

public class PilotSeating : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller != null)
        {
            controller.enabled = false;
            Debug.Log("Character Controller disabled for the flight");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

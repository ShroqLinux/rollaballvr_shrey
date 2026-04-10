using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public GameObject player;
    public float distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float yOffset = 1.5f;
        transform.position = player.transform.position + distance * player.transform.forward;
        transform.position = transform.position + (Vector3.down * 0.25f);
        transform.rotation = player.transform.rotation;
    }
}

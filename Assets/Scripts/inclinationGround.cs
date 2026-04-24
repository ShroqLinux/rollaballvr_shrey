using UnityEngine;

public class inclinationGround : MonoBehaviour
{
    public GameObject ground;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localRotation = Quaternion.Euler(-90f + player.transform.rotation.x, 0f, 90f);
    }
}

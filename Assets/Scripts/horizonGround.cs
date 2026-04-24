using UnityEngine;

public class horizonGround : MonoBehaviour
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
        Debug.Log("Plane Euler: " + player.transform.eulerAngles);
        this.transform.rotation = Quaternion.Euler(-90, 0, 90);
    }
}

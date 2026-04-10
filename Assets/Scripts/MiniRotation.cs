using UnityEngine;

public class MiniRotation : MonoBehaviour
{
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerRotation = player.transform.eulerAngles;
        this.transform.localRotation = Quaternion.Euler(playerRotation.x, playerRotation.y, playerRotation.z);
    }
}

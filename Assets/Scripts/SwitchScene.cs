using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public string scene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.transform.eulerAngles);
        if (this.transform.eulerAngles.x < 120)
        {
            SceneManager.LoadScene(scene);
        }
    }
}

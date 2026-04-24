using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    bool m_IsVisible;
    public GameObject liveImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Toggle()
    {
        Debug.Log("Script toggle triggered");
        m_IsVisible = !m_IsVisible;
        liveImage.SetActive(m_IsVisible);
    }
    void Start()
    {
        m_IsVisible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

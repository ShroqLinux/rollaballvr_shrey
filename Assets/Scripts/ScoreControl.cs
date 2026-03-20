using UnityEngine;
using TMPro;

public class ScoreControl : MonoBehaviour
{
    private int currentScore = 0; // Wir speichern den Score hier
    public PlayerControl playerControl;
    TextMeshPro scoreDisplay;

    void Start() // Nutze Awake für Singletons
    {
        scoreDisplay = GetComponent<TextMeshPro>();
        scoreDisplay.text = "Set First Text";
    }


    void FixedUpdate()
    {
        currentScore = playerControl.score;
        scoreDisplay.text = "Score: " + currentScore.ToString();
    }
}

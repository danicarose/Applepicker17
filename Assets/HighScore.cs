using System.Collections;
using UnityEngine;

public class HighScore : MonoBehaviour {
    static public int score = 1000;

    private void Awake()
    {
        // If the ApplePickerHighScore already exists, read it
        if (PlayerPrefs.HasKey("ApplePickerHighScore"))
        { // 2
            score = PlayerPrefs.GetInt("ApplePickerHighScore");
        }
        // Assign the high score to ApplePickerHighScore
        PlayerPrefs.SetInt("ApplePickerHighScore", score); // 3
    }

    private void Update()
    {
        GUIText gt = this.GetComponent<GUIText>();
        gt.text = "High Score: " + score;

        // Update ApplePickerHighScore in PlayerPrefs if necessary
        if (score > PlayerPrefs.GetInt("ApplePickerHighScore"))
        { // 4
            PlayerPrefs.SetInt("ApplePickerHighScore", score);
        }
    }
}

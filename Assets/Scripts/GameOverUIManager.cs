using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // using this for TextMeshProUGUI since text is different than tutorial


public class GameOverUIManager : MonoBehaviour
{
    // Where the score value will be shown
    public TextMeshProUGUI score;

    // Where the high score value will be shown
    public TextMeshProUGUI highScore;

    // Start is called before the first frame update
    void Start()
    {
        // Show the score and high score
        score.text = GameManager.instance.score.ToString();
        highScore.text = GameManager.instance.highScore.ToString();
    }

    public void RestartGame()
    {
        // Reset the game
        GameManager.instance.Reset();
    }
}

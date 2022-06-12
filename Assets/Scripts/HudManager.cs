using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // using this for TextMeshProUGUI since text is different than tutorial

public class HudManager : MonoBehaviour
{
    // tutorial writes: public Text scoreLabel;
    //  but that cannot be applied to current Unity version as Text is of the form
    //  Text - TextMeshPro
    public TextMeshProUGUI scoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        Refresh();    
    }

    // Show player stats in the HUD
    public void Refresh()
    {
        scoreLabel.text = "Score: " + GameManager.instance.score;
    }
}

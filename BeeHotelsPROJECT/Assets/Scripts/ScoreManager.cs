using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Riferimento all'oggetto Text per visualizzare il punteggio

    private int score = 0;
    private bool activityButtonPressed = false;

    public Button day3Button; // Riferimento al pulsante "Day3"
    public Button activityButton; // Riferimento al pulsante "Activity"

    private void Start()
    {
        day3Button.onClick.AddListener(Day3ButtonPressed);
        activityButton.onClick.AddListener(ActivityButtonPressed);
        UpdateScoreText();
    }

    public void IncrementScore( )
    {
        if (activityButtonPressed)
        {
            score += 10;
        }
        else
        {
            score += 5;
        }

        UpdateScoreText();
    }

    public void ActivityButtonPressed()
    {
        activityButtonPressed = true;
    }

    public void Day3ButtonPressed()
    {
        IncrementScore();
    }

    public void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }
}


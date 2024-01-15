using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Riferimento all'oggetto Text per visualizzare il punteggio

    private int baseScore = 5;
    private int additionalScorePerActivityPress = 5;
    private int activityPressCount = 0;
    private int score = 0;

    public Button day3Button; // Riferimento al pulsante "Day3"
    public Button activityButton; // Riferimento al pulsante "Activity"


    private void Start()
    {
        day3Button.onClick.AddListener(Day3ButtonPressed);
        activityButton.onClick.AddListener(ActivityButtonPressed);
        UpdateScoreText();
    }

    public void Day3ButtonPressed()
    {
        score += baseScore + (activityPressCount * additionalScorePerActivityPress);
        UpdateScoreText();
    }

    public void ActivityButtonPressed()
    {
        activityPressCount++;
    }

    public void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }
}


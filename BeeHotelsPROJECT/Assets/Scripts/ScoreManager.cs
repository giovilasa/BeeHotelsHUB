using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText; // Riferimento all'oggetto Text per visualizzare il punteggio

    private int score = 0;

    private void Start()
    {
        UpdateScoreText();
    }

    public void IncrementScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = score.ToString() + " / XXX";
    }
}


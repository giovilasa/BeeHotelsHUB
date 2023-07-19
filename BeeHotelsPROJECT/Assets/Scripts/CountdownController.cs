using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CountdownController : MonoBehaviour
{
    public TextMeshProUGUI timerText;  // Riferimento al componente TextMeshProUGUI che mostrerà il countdown
    public GameObject waitingObject;  // Riferimento all'oggetto che controlla l'avvio del countdown

    private TimeSpan countdownDuration = TimeSpan.FromHours(24); // 24 ore
    private TimeSpan timeRemaining;  // Tempo rimanente nel countdown
    private bool countdownRunning;  // Indica se il countdown è in esecuzione

    private void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        timeRemaining = countdownDuration;
        UpdateTimerText();

        if (waitingObject == null)
        {
            Debug.Log("waitingObject is null");
        }
        else
        {
            waitingObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (waitingObject.activeSelf)
        {
            if (!countdownRunning)
            {
                StartCountdown();
            }
            else
            {
                UpdateCountdown();
            }
        }
        else
        {
            countdownRunning = false;
        }
    }

    private void StartCountdown()
    {
        countdownRunning = true;
        timeRemaining = countdownDuration;
        UpdateTimerText();
    }

    private void UpdateCountdown()
    {
        timeRemaining -= TimeSpan.FromSeconds(Time.deltaTime);
        if (timeRemaining <= TimeSpan.Zero)
        {
            countdownRunning = false;
            timeRemaining = TimeSpan.Zero;
        }
        UpdateTimerText();
    }

    private void UpdateTimerText()
    {
        int hours = timeRemaining.Hours;
        int minutes = timeRemaining.Minutes;
        int seconds = timeRemaining.Seconds;

        string formattedTime = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        timerText.text = formattedTime;
    }
}

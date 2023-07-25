using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CountdownController : MonoBehaviour
{
    public TextMeshProUGUI timerText;  // Reference to the TextMeshProUGUI component which will display the countdown
    public GameObject waitingObject;  // Reference to the TextMeshProUGUI component which will display the countdown

    private TimeSpan countdownDuration = TimeSpan.FromHours(24); // 24 hours
    private TimeSpan timeRemaining;  // Time remaining in the countdown
    private bool countdownRunning;  // Indicates whether the countdown is running

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

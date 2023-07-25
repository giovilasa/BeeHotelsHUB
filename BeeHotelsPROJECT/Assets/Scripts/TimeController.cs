using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeController : MonoBehaviour
{
    public TextMeshProUGUI timerText;  // Reference to the TextMeshProUGUI component which will display the timer
    private float startTime;  // Timer start time
    private bool timerRunning;  // Indicates if the timer is running

    private int startingHour = 12;
    private int startingMinute = 10;
    private int startingSecond = 0;

    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();

        if (timerText == null)
        {
            Debug.Log("timerText is null");
        }
        else
        {
            Debug.Log("timerText is assigned");
        }

        startTime = Time.time;
        timerRunning = true;

        // Set the departure time
        startTime = Time.time - GetTotalElapsedTime();
    }

    void Update()
    {
        if (timerRunning)
        {
            // Calculate the total elapsedTime
            float totalElapsedTime = GetTotalElapsedTime();

            // Convert total time to hours, minutes and seconds
            int hours = startingHour + (int)(totalElapsedTime / 3600);
            int minutes = startingMinute + (int)((totalElapsedTime % 3600) / 60);
            int seconds = startingSecond + (int)(totalElapsedTime % 60);

            // Format the values to display the time in the format "hh:mm:ss"
            string formattedTime = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");

            // Update timer text
            timerText.text = formattedTime;
        }
    }

    private float GetTotalElapsedTime()
    {
        // Calculate the total elapsedTime from the start
        return Time.time - startTime;
    }

    public void RestartTimer()
    {
        startTime = Time.time;
    }
}

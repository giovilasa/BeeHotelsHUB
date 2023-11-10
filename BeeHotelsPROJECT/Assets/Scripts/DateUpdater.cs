using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class DateUpdater : MonoBehaviour
{
    public TextMeshProUGUI dateText;  // Reference to the TextMeshProUGUI component for displaying the date
    public Button[] dateChangeButtons;  // Array of buttons to change the date

    private DateTime currentDate;  // Variable to store the current date

    void Start()
    {
        // Ensure that the TextMeshProUGUI component is assigned
        if (dateText == null)
        {
            Debug.LogError("dateText is not assigned. Please assign it in the Unity Editor.");
        }

        // Ensure that the dateChangeButtons array is assigned
        if (dateChangeButtons == null || dateChangeButtons.Length == 0)
        {
            Debug.LogError("dateChangeButtons array is not assigned or is empty. Please assign buttons in the Unity Editor.");
        }
        else
        {
            // Assign the Click event handler for each button in the array
            foreach (Button button in dateChangeButtons)
            {
                button.onClick.AddListener(IncrementDate);
            }
        }

        // Initialize the current date
        currentDate = DateTime.Now;

        // Update the dateText with the current date
        UpdateDateText();
    }

    void IncrementDate()
    {
        // Increment the current date by one day
        currentDate = currentDate.AddDays(1);

        // Update the dateText with the new date
        UpdateDateText();
    }

    void UpdateDateText()
    {
        // Format the current date as a string
        string formattedDate = currentDate.ToString("dd/MM/yyyy");

        // Update the dateText with the current date
        dateText.text = formattedDate;
    }
}

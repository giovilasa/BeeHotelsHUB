using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class DayMagarer : MonoBehaviour
{
    public Button[] buttonsToMonitor;
    public GameObject spawnPoint;

    private void Start()
    {
        foreach (Button button in buttonsToMonitor)
        {
            button.onClick.AddListener(OnButtonPressed);
        }
    }

    private void OnButtonPressed()
    {
        bool allButtonsPressed = true;

        foreach (Button button in buttonsToMonitor)
        {
            if (!button.interactable)
            {
                allButtonsPressed = false;
                break;
            }
        }

        if (allButtonsPressed)
        {
            // Apparizione dell'oggetto nella scena
            spawnPoint.SetActive(true);
        }
    }
}

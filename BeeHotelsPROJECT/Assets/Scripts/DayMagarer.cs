using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class DayMagarer : MonoBehaviour
{
    public Button[] buttonsToMonitor;
    public GameObject spawnPoint;

    private int buttonsPressedCount = 0;

    private void Start()
    {
        foreach (Button button in buttonsToMonitor)
        {
            button.onClick.AddListener(() => OnButtonPressed(button));
        }
    }

    private void OnButtonPressed(Button pressedButton)
    {
        // Verifica se il bottone è già stato premuto
        if (!pressedButton.interactable)
        {
            return;
        }

        // Incrementa il contatore solo se il bottone non è già stato premuto
        buttonsPressedCount++;

        // Disabilita il bottone appena premuto
        pressedButton.interactable = false;

        // Verifica se sono stati premuti tutti i bottoni
        if (buttonsPressedCount == buttonsToMonitor.Length)
        {
            buttonsPressedCount = 0; // Reimposta il contatore
            spawnPoint.SetActive(true); // Attiva il punto di spawn
        }
    }
}

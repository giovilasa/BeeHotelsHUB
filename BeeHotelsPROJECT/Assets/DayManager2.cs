using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class DayManager2 : MonoBehaviour
{
    public Button[] buttonsToMonitor;
    public GameObject spawnPoint;

    private bool spawnPointActivated = false;

    private void Start()
    {
        foreach (Button button in buttonsToMonitor)
        {
            button.onClick.AddListener(() => OnButtonPressed(button));
        }
    }

    private void OnButtonPressed(Button pressedButton)
    {
        if (!spawnPointActivated && pressedButton.interactable)
        {
            pressedButton.interactable = false;

            // Verifica se almeno uno tra diversi bottoni è stato premuto
            bool anyButtonPressed = buttonsToMonitor.Any(button => !button.interactable);

            // Se almeno uno dei bottoni è stato premuto, attiva il punto di spawn
            if (anyButtonPressed)
            {
                spawnPoint.SetActive(true);
                spawnPointActivated = true;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class EndgameManager : MonoBehaviour
{
    public Button[] buttonsToMonitor;
    public GameObject spawnPoint;
    public GameObject[] objectsToDisable;

    private int buttonIndex = 0; // Indice del prossimo bottone da premere nell'ordine corretto

    private void Start()
    {
        foreach (Button button in buttonsToMonitor)
        {
            button.onClick.AddListener(() => OnButtonPressed(button));
        }
    }

    private void OnButtonPressed(Button pressedButton)
    {
        // Verifica se il bottone premuto è quello corretto nell'ordine
        if (pressedButton == buttonsToMonitor[buttonIndex])
        {
            // Disattiva il bottone premuto in modo che non possa essere premuto di nuovo
            pressedButton.interactable = false;

            buttonIndex++; // Passa al prossimo bottone nell'ordine corretto

            // Verifica se tutti i bottoni sono stati premuti nell'ordine corretto
            if (buttonIndex == buttonsToMonitor.Length)
            {
                // Disattiva gli oggetti nell'array "objectstodisable"
                foreach (GameObject obj in objectsToDisable)
                {
                    obj.SetActive(false);
                }

                // Apparizione dell'oggetto nella scena
                spawnPoint.SetActive(true);
            }
        }
        else
        {
            // Resetta l'ordine dei bottoni se viene premuto un bottone sbagliato
            buttonIndex = 0;

            // Riattiva tutti i bottoni per riprovare
            foreach (Button button in buttonsToMonitor)
            {
                button.interactable = true;
            }
        }
    }
}

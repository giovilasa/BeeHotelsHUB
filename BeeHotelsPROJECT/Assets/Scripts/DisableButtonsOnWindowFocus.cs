using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableButtonsOnWindowFocus : MonoBehaviour
{
    public GameObject windowObject; // Riferimento all'oggetto finestra
    public Button[] buttonsToDisable; // Array contenente i pulsanti da disabilitare

    private void OnEnable()
    {
        // Quando la finestra viene attivata, disabilita i pulsanti
        DisableButtons();
    }

    private void OnDisable()
    {
        // Quando la finestra viene disattivata, riabilita i pulsanti
        EnableButtons();
    }

    private void DisableButtons()
    {
        // Disabilita i pulsanti
        foreach (Button button in buttonsToDisable)
        {
            button.interactable = false;
        }
    }

    private void EnableButtons()
    {
        // Abilita i pulsanti
        foreach (Button button in buttonsToDisable)
        {
            button.interactable = true;
        }
    }
}

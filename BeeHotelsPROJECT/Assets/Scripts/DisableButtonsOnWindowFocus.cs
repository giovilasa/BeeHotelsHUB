using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableButtonsOnWindowFocus : MonoBehaviour
{
    public GameObject windowObject; // Reference to the window object
    public Button[] buttonsToDisable; // Array containing the buttons to disable

    private void OnEnable()
    {
        // When the window is activated, it disables the buttons
        DisableButtons();
    }

    private void OnDisable()
    {
        // When the window is deactivated, it re-enables the buttons
        EnableButtons();
    }

    private void DisableButtons()
    {
        // Disable buttons
        foreach (Button button in buttonsToDisable)
        {
            button.interactable = false;
        }
    }

    private void EnableButtons()
    {
        // Enable buttons
        foreach (Button button in buttonsToDisable)
        {
            button.interactable = true;
        }
    }
}

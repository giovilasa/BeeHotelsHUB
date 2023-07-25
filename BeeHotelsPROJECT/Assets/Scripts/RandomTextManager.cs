using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomTextManager : MonoBehaviour
{
    public TextMeshProUGUI phraseText; // Reference to the Text object to show the sentence
    public Button[] buttons; // Array of buttons that must activate the display of the sentences
    public string[] phrases; // Phrases array

    private bool areButtonsActive = false;

    private void Start()
    {
        DisableButtons();
    }

    public void EnableButtons()
    {
        areButtonsActive = true;
        foreach (Button button in buttons)
        {
            button.interactable = true;
        }
    }

    public void DisableButtons()
    {
        areButtonsActive = false;
        foreach (Button button in buttons)
        {
            button.interactable = false;
        }
    }

    private void OnButtonClick()
    {
        if (!areButtonsActive)
        {
            return;
        }

        // Get a random phrase
        string randomPhrase = GetRandomPhrase();

        // Show the phrase on screen
        phraseText.text = randomPhrase;
    }

    private string GetRandomPhrase()
    {
        // Get a random number as an index to access the phrase in the list
        int randomIndex = Random.Range(0, phrases.Length);

        // Return the random phrase
        return phrases[randomIndex];
    }

}

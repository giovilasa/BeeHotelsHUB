using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomTextManager : MonoBehaviour
{
    public TextMeshProUGUI phraseText; // Riferimento all'oggetto Text per mostrare la frase
    public Button[] buttons; // Array di pulsanti che devono attivare la visualizzazione delle frasi
    public string[] phrases; // Array di frasi

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

        // Ottieni una frase casuale
        string randomPhrase = GetRandomPhrase();

        // Mostra la frase a schermo
        phraseText.text = randomPhrase;
    }

    private string GetRandomPhrase()
    {
        // Ottieni un numero casuale come indice per accedere alla frase nella lista
        int randomIndex = Random.Range(0, phrases.Length);

        // Restituisci la frase casuale
        return phrases[randomIndex];
    }

}

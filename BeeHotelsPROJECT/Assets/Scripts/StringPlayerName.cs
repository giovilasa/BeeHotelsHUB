using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class StringPlayerName : MonoBehaviour
{
    public TextMeshProUGUI usernameText; // Riferimento al componente TextMeshProUGUI del testo "Username".

    // Funzione per sostituire le stringhe "[NomeGiocatore]" con il contenuto del testo "Username".
    public void ReplacePlayerNameInTexts()
    {
        string playerName = usernameText.text;

        // Trova tutti gli oggetti di testo TextMeshPro nella scena.
        TextMeshProUGUI[] allTexts = FindObjectsOfType<TextMeshProUGUI>();

        foreach (TextMeshProUGUI text in allTexts)
        {
            // Se il testo contiene la stringa "[NomeGiocatore]", sostituisci con il contenuto del testo "Username".
            if (text.text.Contains("[NomeGiocatore]"))
            {
                text.text = text.text.Replace("[NomeGiocatore]", playerName);
            }
        }
    }
}

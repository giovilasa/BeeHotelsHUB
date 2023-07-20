using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StringManagerName : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextManager textManager;

    public void OnConfirmButtonClicked()
    {
        string playerName = inputField.text;

        // Chiamiamo il metodo SetPlayerName di "TextManager" per impostare il nome del giocatore e aggiornare i testi.
        textManager.SetPlayerName(playerName);
    }
}

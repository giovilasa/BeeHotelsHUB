using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNameInput : MonoBehaviour
{
    // Riferimento allo script StringPlayerName.
    public StringPlayerName stringPlayerName;

    // Funzione chiamata quando il bottone viene premuto.
    public void OnButtonClick()
    {
        // Chiamiamo la funzione ReplacePlayerNameInTexts() dallo script StringPlayerName.
        stringPlayerName.ReplacePlayerNameInTexts();
    }
}

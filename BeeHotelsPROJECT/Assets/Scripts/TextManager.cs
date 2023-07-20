using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public static TextManager Instance;
    public GameObject[] objectsToReplace; // Dichiarazione dell'array di GameObject.
    private string playerName;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetPlayerName(string name)
    {
        if (string.IsNullOrEmpty(playerName))
        {
            playerName = name;
            UpdateTexts(); // Esegue la sostituzione nei GameObject specificati nell'array.
        }
    }

    private void UpdateTexts()
    {
        // Controllo se playerName è valido per evitare sostituzioni indesiderate.
        if (!string.IsNullOrEmpty(playerName))
        {
            // Itero attraverso gli oggetti nell'array objectsToReplace.
            foreach (GameObject obj in objectsToReplace)
            {
                // Controllo se l'oggetto contiene il componente TextMeshProUGUI.
                TextMeshProUGUI textComponent = obj.GetComponent<TextMeshProUGUI>();
                if (textComponent != null)
                {
                    // Sostituisco la stringa "[NomeGiocatore]" con playerName.
                    string newText = textComponent.text.Replace("[NomeGiocatore]", playerName);
                    textComponent.text = newText;
                }
            }
        }
    }
}

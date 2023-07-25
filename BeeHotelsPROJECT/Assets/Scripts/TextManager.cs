using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public static TextManager Instance;
    public GameObject[] objectsToReplace; // GameObject array declaration.
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
            UpdateTexts(); // GameObject array declaration.
        }
    }

    private void UpdateTexts()
    {
        // Check if playerName is valid to avoid unwanted substitutions.
        if (!string.IsNullOrEmpty(playerName))
        {
            // I iterate through the objects in the objectsToReplace array.
            foreach (GameObject obj in objectsToReplace)
            {
                // Checking if the object contains the TextMeshProUGUI component.
                TextMeshProUGUI textComponent = obj.GetComponent<TextMeshProUGUI>();
                if (textComponent != null)
                {
                    // I replace the string "[NomeGiocatore]" with playerName.
                    string newText = textComponent.text.Replace("[NomeGiocatore]", playerName);
                    textComponent.text = newText;
                }
            }
        }
    }
}

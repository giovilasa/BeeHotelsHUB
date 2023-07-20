using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerNameManager : MonoBehaviour
{
    public TMP_InputField inputField;
    public List<TextMeshProUGUI> playerNameTexts;
    public Button confirmButton;

    private void Start()
    {
        confirmButton.onClick.AddListener(OnConfirmButtonClicked);
    }

    public void OnConfirmButtonClicked()
    {
        string playerName = inputField.text;

        TextManager.Instance.SetPlayerName(playerName); // Chiamiamo la funzione di TextManager per impostare il nome del giocatore.

        foreach (var textComponent in playerNameTexts)
        {
            textComponent.text = playerName;
        }

        inputField.interactable = false;
        confirmButton.interactable = false;
    }
}

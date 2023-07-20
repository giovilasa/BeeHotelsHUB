using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerNameManager : MonoBehaviour
{
    public TMP_InputField inputField;
    public List<TextMeshProUGUI> playerNameTexts; // Lista di altre componenti di testo
    public Button confirmButton;

    private string playerName;

    private void Start()
    {
        confirmButton.onClick.AddListener(OnConfirmButtonClicked);
    }

    public void OnConfirmButtonClicked()
    {
        playerName = inputField.text;
        foreach (var textComponent in playerNameTexts)
        {
            textComponent.text = playerName;
        }

        // Disabilita l'interazione con il campo di input dopo la conferma
        inputField.interactable = false;
        confirmButton.interactable = false;
    }
}

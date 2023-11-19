using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageVisibilityHandler : MonoBehaviour
{
    public Scrollbar scrollbar;
    public GameObject[] images;
    public Button[] buttonsA; // Bottoni "A"
    public Button[] buttonsD; // Bottoni "D"

    private int imageCount;
    private List<int> visibleImageIndices = new List<int>(); // Lista degli indici delle immagini visibili

    private void Start()
    {
        imageCount = images.Length;
        scrollbar.onValueChanged.AddListener(OnScrollValueChanged);

        // Aggiunge listener a ciascun bottone "A"
        foreach (Button button in buttonsA)
        {
            button.onClick.AddListener(() => OnButtonAClick(button));
        }

        // Aggiunge listener a ciascun bottone "D"
        foreach (Button button in buttonsD)
        {
            button.onClick.AddListener(() => OnButtonDClick(button));
        }
    }

    private void OnButtonAClick(Button clickedButton)
    {
        // Trova l'indice del pulsante "A" cliccato nell'array di pulsanti "A"
        int buttonIndex = System.Array.IndexOf(buttonsA, clickedButton);

        // Se l'indice è valido, gestisce il comportamento
        if (buttonIndex >= 0 && buttonIndex < imageCount)
        {
            // Aggiunge o rimuove l'indice dall'elenco delle immagini visibili
            if (visibleImageIndices.Contains(buttonIndex))
            {
                visibleImageIndices.Remove(buttonIndex);
            }
            else
            {
                visibleImageIndices.Add(buttonIndex);
            }

            UpdateVisibleImages();
        }
    }

    private void OnButtonDClick(Button clickedButton)
    {
        // Trova l'indice del pulsante "D" cliccato nell'array di pulsanti "D"
        int buttonIndex = System.Array.IndexOf(buttonsD, clickedButton);

        // Se l'indice è valido, gestisce il comportamento
        if (buttonIndex >= 0 && buttonIndex < imageCount)
        {
            // Nasconde l'immagine associata al pulsante "D" cliccato
            visibleImageIndices.Remove(buttonIndex);
            UpdateVisibleImages();
        }
    }

    private void OnScrollValueChanged(float scrollValue)
    {
        int imageIndex = Mathf.FloorToInt(scrollValue * (imageCount - 1));
        SetActiveImage(imageIndex);
    }

    private void SetActiveImage(int imageIndex)
    {
        // Verifica se l'immagine corrente è tra quelle visibili
        if (visibleImageIndices.Contains(imageIndex))
        {
            for (int i = 0; i < imageCount; i++)
            {
                images[i].SetActive(i == imageIndex);
            }
        }
    }

    private void UpdateVisibleImages()
    {
        // Ricava l'indice corrente dalla scrollbar
        float scrollValue = scrollbar.value;
        int imageIndex = Mathf.FloorToInt(scrollValue * (imageCount - 1));

        // Verifica se l'immagine corrente è tra quelle non visibili
        if (!visibleImageIndices.Contains(imageIndex))
        {
            // Cerca la prima immagine visibile prima di quella corrente
            for (int i = imageIndex - 1; i >= 0; i--)
            {
                if (visibleImageIndices.Contains(i))
                {
                    imageIndex = i;
                    break;
                }
            }

            // Se non ci sono immagini visibili prima di quella corrente, cerca la prima immagine visibile dopo di essa
            if (!visibleImageIndices.Contains(imageIndex))
            {
                for (int i = imageIndex + 1; i < imageCount; i++)
                {
                    if (visibleImageIndices.Contains(i))
                    {
                        imageIndex = i;
                        break;
                    }
                }
            }
        }

        SetActiveImage(imageIndex);
    }
}

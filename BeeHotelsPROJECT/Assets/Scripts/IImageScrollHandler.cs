using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IImageScrollHandler : MonoBehaviour
{
    public Scrollbar scrollbar;
    public GameObject[] images;
    public Button[] buttons; // Aggiunto array di bottoni

    private int imageCount;
    private List<int> inactiveImageIndices = new List<int>(); // Lista degli indici delle immagini non attive

    private void Start()
    {
        imageCount = images.Length;
        scrollbar.onValueChanged.AddListener(OnScrollValueChanged);

        // Aggiunge listener a ciascun bottone
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => OnButtonClick(button));
        }
    }

    private void OnButtonClick(Button clickedButton)
    {
        // Trova l'indice del pulsante cliccato nell'array di pulsanti
        int buttonIndex = System.Array.IndexOf(buttons, clickedButton);

        // Se l'indice è valido, gestisce il comportamento
        if (buttonIndex >= 0 && buttonIndex < imageCount)
        {
            // Se il bottone è già stato premuto, lo attiva; altrimenti, lo disattiva
            if (inactiveImageIndices.Contains(buttonIndex))
            {
                inactiveImageIndices.Remove(buttonIndex);
            }
            else
            {
                inactiveImageIndices.Add(buttonIndex);
            }

            UpdateActiveImages();
        }
    }

    private void OnScrollValueChanged(float scrollValue)
    {
        int imageIndex = Mathf.FloorToInt(scrollValue * (imageCount - 1));
        SetActiveImage(imageIndex);
    }

    private void SetActiveImage(int imageIndex)
    {
        // Verifica se l'immagine corrente è tra quelle attive
        if (!inactiveImageIndices.Contains(imageIndex))
        {
            for (int i = 0; i < imageCount; i++)
            {
                images[i].SetActive(i == imageIndex);
            }
        }
    }

    private void UpdateActiveImages()
    {
        // Ricava l'indice corrente dalla scrollbar
        float scrollValue = scrollbar.value;
        int imageIndex = Mathf.FloorToInt(scrollValue * (imageCount - 1));

        // Verifica se l'immagine corrente è tra quelle non attive
        if (inactiveImageIndices.Contains(imageIndex))
        {
            // Cerca la prima immagine attiva prima di quella corrente
            for (int i = imageIndex - 1; i >= 0; i--)
            {
                if (!inactiveImageIndices.Contains(i))
                {
                    imageIndex = i;
                    break;
                }
            }

            // Se non ci sono immagini attive prima di quella corrente, cerca la prima immagine attiva dopo di essa
            if (inactiveImageIndices.Contains(imageIndex))
            {
                for (int i = imageIndex + 1; i < imageCount; i++)
                {
                    if (!inactiveImageIndices.Contains(i))
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


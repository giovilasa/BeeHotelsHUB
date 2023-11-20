using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageVisibilityHandler : MonoBehaviour
{
    public Scrollbar scrollbar;
    public GameObject[] images;
    public Button[] disableButtons;
    public Button[] newButtons;
    private int imageCount;
    private List<int> activeImageIndices = new List<int>();


    private void Start()
    {
        imageCount = images.Length;
        scrollbar.onValueChanged.AddListener(OnScrollValueChanged);

        // Aggiunge listener a ciascun bottone per disabilitare le immagini
        foreach (Button button in disableButtons)
        {
            button.onClick.AddListener(() => OnButtonClick(button));
        }

        // Aggiunge listener a ciascun nuovo bottone
        foreach (Button button in newButtons)
        {
            button.onClick.AddListener(() => OnNewButtonClick(button));
        }

        // Disabilita tutte le immagini all'inizio
        DisableAllImages();
    }

    private void OnButtonClick(Button clickedButton)
    {
        int buttonIndex = System.Array.IndexOf(disableButtons, clickedButton);
        if (buttonIndex >= 0 && buttonIndex < imageCount)
        {
            ToggleImageActivation(buttonIndex);
        }
    }

    private void OnNewButtonClick(Button clickedButton)
    {
        int buttonIndex = System.Array.IndexOf(newButtons, clickedButton);
        if (buttonIndex >= 0 && buttonIndex < imageCount)
        {
            ToggleImageActivation(buttonIndex);
        }
    }

    private void ToggleImageActivation(int buttonIndex)
    {
        if (activeImageIndices.Contains(buttonIndex))
        {
            activeImageIndices.Remove(buttonIndex);
        }
        else
        {
            activeImageIndices.Add(buttonIndex);
        }

        UpdateActiveImages();
    }

    private void OnScrollValueChanged(float scrollValue)
    {
        int imageIndex = Mathf.RoundToInt(scrollValue * (imageCount - 1));
        SetActiveImage(imageIndex);
    }

    private void SetActiveImage(int imageIndex)
    {
        if (activeImageIndices.Contains(imageIndex))
        {
            images[imageIndex].SetActive(true);
        }
        else
        {
            images[imageIndex].SetActive(false);
        }
    }

    private void UpdateActiveImages()
    {
        float scrollValue = scrollbar.value;
        int imageIndex = Mathf.FloorToInt(scrollValue * (imageCount - 1));

        // Cerca la prima immagine attiva prima di quella corrente
        for (int i = imageIndex; i >= 0; i--)
        {
            if (!activeImageIndices.Contains(i))
            {
                imageIndex = i;
                break;
            }
        }

        // Se non ci sono immagini attive prima di quella corrente, cerca la prima immagine attiva dopo di essa
        if (activeImageIndices.Contains(imageIndex))
        {
            for (int i = imageIndex + 1; i < imageCount; i++)
            {
                if (!activeImageIndices.Contains(i))
                {
                    imageIndex = i;
                    break;
                }
            }
        }

        SetActiveImage(imageIndex);
    }

    private void DisableAllImages()
    {
        foreach (var image in images)
        {
            image.SetActive(false);
        }
    }
}

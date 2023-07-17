using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NotificationSystem : MonoBehaviour
{
    [System.Serializable]
    public class ContainerElements
    {
        public Texture2D firstIconTexture;
        public Texture2D secondIconTexture;
        public string text;
    }

    public GameObject[] containers;  // Array dei contenitori
    private int currentContainerIndex = 0;  // Indice del contenitore corrente

    // Riferimenti agli elementi all'interno dei contenitori
    public RawImage[] firstIcons;
    public RawImage[] secondIcons;
    public TextMeshProUGUI[] texts;

    // Riferimenti alle nuove carte
    public GameObject NewCard1;
    public GameObject NewCard2;
    public GameObject NewCard3;
    public GameObject NewCard4;

    // Array degli elementi di modifica dei contenitori per ogni nuova carta
    public ContainerElements[] newCardContainerElements;

    private bool activityButtonClicked = false; // Flag per controllare se il pulsante "Activity" è stato premuto


    public void SetActivityButtonClicked(bool value)
    {
        activityButtonClicked = value;
    }

    private void Start()
    {
        // Assicurati che i contenitori siano disattivati all'inizio del gioco, tranne il primo
        for (int i = 1; i < containers.Length; i++)
        {
            containers[i].SetActive(false);
        }
    }

    public void ModifyContainerElements(int newIndex)
    {
        // Verifica se l'indice specificato è valido
        if (newIndex >= 0 && newIndex < newCardContainerElements.Length)
        {
            // Ottieni gli elementi del contenitore corrente dall'array newCardContainerElements
            ContainerElements currentContainerElements = newCardContainerElements[newIndex];

            // Disattiva il contenitore corrente
            containers[currentContainerIndex].SetActive(false);

            // Accedi agli oggetti appropriati in base alla carta attiva
            RawImage currentFirstIcon = null;
            RawImage currentSecondIcon = null;
            TextMeshProUGUI currentText = null;

            if (NewCard1.activeSelf)
            {
                currentFirstIcon = firstIcons[currentContainerIndex];
                currentSecondIcon = secondIcons[currentContainerIndex];
                currentText = texts[currentContainerIndex];
            }
            else if (NewCard2.activeSelf)
            {
                currentFirstIcon = firstIcons[currentContainerIndex];
                currentSecondIcon = secondIcons[currentContainerIndex];
                currentText = texts[currentContainerIndex];
            }
            else if (NewCard3.activeSelf)
            {
                currentFirstIcon = firstIcons[currentContainerIndex];
                currentSecondIcon = secondIcons[currentContainerIndex];
                currentText = texts[currentContainerIndex];
            }
            else if (NewCard4.activeSelf)
            {
                currentFirstIcon = firstIcons[currentContainerIndex];
                currentSecondIcon = secondIcons[currentContainerIndex];
                currentText = texts[currentContainerIndex];
            }

            // Modifica gli elementi del contenitore corrente con i valori appropriati
            currentFirstIcon.texture = currentContainerElements.firstIconTexture;
            currentSecondIcon.texture = currentContainerElements.secondIconTexture;
            currentText.text = currentContainerElements.text;

            // Attiva il contenitore corrente
            containers[currentContainerIndex].SetActive(true);

            // Passa al contenitore successivo
            currentContainerIndex++;

            // Se abbiamo superato l'ultimo contenitore, torna al primo
            if (currentContainerIndex >= containers.Length)
            {
                currentContainerIndex = 0;
            }

        }
        else
        {
            Debug.LogWarning("Invalid index specified for ModifyContainerElements().");
        }
    }

    public void ModifyContainerElements() //ACTIVITY
    {
        if (activityButtonClicked)
        {
            // Ottieni gli elementi del contenitore corrente dall'array newCardContainerElements
            ContainerElements currentContainerElements = newCardContainerElements[currentContainerIndex];

            // Disattiva il contenitore corrente
            containers[currentContainerIndex].SetActive(false);

            // Accedi agli oggetti appropriati in base alla carta attiva
            RawImage currentFirstIcon = firstIcons[currentContainerIndex];
            RawImage currentSecondIcon = secondIcons[currentContainerIndex];
            TextMeshProUGUI currentText = texts[currentContainerIndex];

            // Modifica gli elementi del contenitore corrente con i valori appropriati
            currentFirstIcon.texture = currentContainerElements.firstIconTexture;
            currentSecondIcon.texture = currentContainerElements.secondIconTexture;
            currentText.text = currentContainerElements.text;

            // Passa al contenitore successivo
            currentContainerIndex++;

            // Se abbiamo superato l'ultimo contenitore, torna al primo
            if (currentContainerIndex >= containers.Length)
            {
                currentContainerIndex = 0;
            }

            // Attiva il contenitore corrente
            containers[currentContainerIndex].SetActive(true);
        }
    }
}


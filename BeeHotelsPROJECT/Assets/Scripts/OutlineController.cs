using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutlineController : MonoBehaviour
{
    public Material outlineMaterial; // Materiale con lo shader di contorno
    private Material originalMaterial; // Materiale originale dell'oggetto
    private Renderer objectRenderer;

    public Button buttonA; // Pulsante associato a ButtonA
    public Button buttonB; // Pulsante associato a ButtonB

    void Start()
    {
        // Assicurati che l'oggetto abbia un Renderer
        objectRenderer = GetComponent<Renderer>();

        // Salva il materiale originale
        originalMaterial = objectRenderer.material;

        // Aggiungi il gestore di eventi ai pulsanti A e B
        if (buttonA != null)
        {
            buttonA.onClick.AddListener(() => OnButtonAClicked());
        }

        if (buttonB != null)
        {
            buttonB.onClick.AddListener(() => OnButtonBClicked());
        }
    }

    void OnButtonAClicked()
    {
        ApplyOutlineEffect();
    }

    void OnButtonBClicked()
    {
        RemoveOutlineEffect();
    }

    void ApplyOutlineEffect()
    {
        // Cambia il materiale con quello che ha lo shader di contorno
        objectRenderer.material = outlineMaterial;
    }

    void RemoveOutlineEffect()
    {
        // Ripristina il materiale originale
        objectRenderer.material = originalMaterial;
    }
}

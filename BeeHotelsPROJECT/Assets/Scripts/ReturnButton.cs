using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnButton : MonoBehaviour
{
    public GameObject CurrUI;
    public GameObject BackUI;
    private bool isBackUIActive = false;
    private bool isCurrUIActive = true;

    public AudioSource buttonClickAudioSource;

    
    void Start()
    {
        if (buttonClickAudioSource == null)
        {
            Debug.LogError("AudioSource non assegnato al componente ButtonClickSound.");
        }
    }
    public void OnButtonClick()
    {
        isBackUIActive = !isBackUIActive; 
        BackUI.SetActive(isBackUIActive);
        isCurrUIActive = !isCurrUIActive; 
        CurrUI.SetActive(isCurrUIActive);
        buttonClickAudioSource.Play();
    }

}

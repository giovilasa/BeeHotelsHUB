using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject[] menus;
    [SerializeField] private GameObject initialMenu; // Specifica il menu da attivare all'inizio

    private GameObject currentMenu;

    public AudioSource buttonClickAudioSource;


    private void Start()
    {
        //Debug.Log("Start: Nasconde tutti i menu");
        HideAllMenus();
        
        // Attiva il menu iniziale specificato
        if (initialMenu != null)
        {
            //Debug.Log("Start: Attiva il menu iniziale specificato");
            ShowMenu(initialMenu);
        }
    }

    
    public void ShowMenu(GameObject menu)
    {
        HideCurrentMenu();
        ShowSpecificMenu(menu);
        buttonClickAudioSource.Play();
    }

    public void HideCurrentMenu()
    {
        if (currentMenu != null)
        {
            currentMenu.SetActive(false);
            currentMenu = null;
        }
    }

    private void ShowSpecificMenu(GameObject menu)
    {
        menu.SetActive(true);
        currentMenu = menu;
    }

    public void HideAllMenus()
    {
        // Nasconde tutti i menu
        foreach (GameObject menu in menus)
        {
            Debug.Log("HideAll: Nasconde tutti i menu");
            menu.SetActive(false);
        }
        currentMenu = null;
    }

    public void ShowStartMenu(GameObject menu)
    {
        HideAllMenus();
        ShowSpecificMenu(menu);
        buttonClickAudioSource.Play();
    }
}

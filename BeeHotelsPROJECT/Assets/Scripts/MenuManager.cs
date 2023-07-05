using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    [SerializeField] private GameObject[] menus;
    [SerializeField] private GameObject initialMenu; // Specifica il menu da attivare all'inizio

    private GameObject currentMenu;

    private void Start()
    {
        HideAllMenus();

        // Attiva il menu iniziale specificato
        if (initialMenu != null)
        {
            ShowMenu(initialMenu);
        }
    }

    public void ShowMenu(GameObject menu)
    {
        // Nasconde il menu corrente se esiste
        HideCurrentMenu();

        // Mostra il menu specificato
        menu.SetActive(true);
        currentMenu = menu;
    }

    public void HideCurrentMenu()
    {
        if (currentMenu != null)
        {
            // Nasconde il menu corrente
            currentMenu.SetActive(false);
            currentMenu = null;
        }
    }

    public void HideAllMenus()
    {
        // Nasconde tutti i menu
        foreach (GameObject menu in menus)
        {
            menu.SetActive(false);
        }
        currentMenu = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

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
        Debug.Log("ShowMenu: Nasconde il menu corrente se esiste");
        // Nasconde il menu corrente se esiste
        HideCurrentMenu();

        Debug.Log("ShowMenu: Mostra il menu specificato");
        // Mostra il menu specificato
        menu.SetActive(true);
        currentMenu = menu;
    }

    public void HideCurrentMenu()
    {
        if (currentMenu != null)
        {
            Debug.Log("HideCurrent: Nasconde il menu corrente");
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
            Debug.Log("HideAll: Nasconde tutti i menu");
            menu.SetActive(false);
        }
        currentMenu = null;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager2 : MonoBehaviour
{
    public GameObject CurrWindow;
    public GameObject NewWindow;

    
    void Start()
    {
        NewWindow.SetActive(false);
    }

    
    public void OnMouseDown()
    {
        CurrWindow.SetActive(false);
        NewWindow.SetActive(true);
    }
}

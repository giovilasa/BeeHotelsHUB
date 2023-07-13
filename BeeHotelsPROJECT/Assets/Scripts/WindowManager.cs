using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowManager : MonoBehaviour
{
    public GameObject windowCanvas;
    
    
    void Start()
    {
        CloseWindow();
    }

    public void OnMouseDown()
    {
        windowCanvas.SetActive(true);
    }

    public void CloseWindow()
    {
        windowCanvas.SetActive(false);
    }


}

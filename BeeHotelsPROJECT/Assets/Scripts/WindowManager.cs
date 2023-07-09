using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WindowManager : MonoBehaviour
{
    public GameObject windowCanvas;

    // Start is called before the first frame update
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaitingScript : MonoBehaviour
{
    public GameObject takeButton;
    public GameObject waitObject;

    public void OnMouseDown()
    {
        takeButton.SetActive(false);
        waitObject.SetActive(true);
    }
}

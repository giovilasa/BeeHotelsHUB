using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayChanger : MonoBehaviour
{
    public GameObject[] objectsToDisable;
    public GameObject[] objectsToDestroy;
    public GameObject[] objectsToEnable;
    public GameObject[] windowsToClose;

    public TimeController timeController; // Reference to the TimeController script

    public void DisableObjects()
    {
        foreach (GameObject obj in objectsToDisable)
        {
            obj.SetActive(false);
        }
    }

    public void DestroyObjects()
    {
        foreach (GameObject obj in objectsToDestroy)
        {
            Destroy(obj);
        }
    }

    public void EnableObjects()
    {
        foreach (GameObject obj in objectsToEnable)
        {
            obj.SetActive(true);
        }
    }

    public void CloseWindows()
    {
        foreach (GameObject obj in windowsToClose)
        {
            obj.SetActive(false);
        }
    }

    public void RestartTimer()
    {
        timeController.RestartTimer();
    }
}

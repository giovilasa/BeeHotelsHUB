using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnStart : MonoBehaviour
{
    public Camera MainCamera;
    public Light MainLight;
    public Camera StartCamera;
    public Light StartLight;

    public GameObject StartBackground;
    public GameObject Start;

    public void OnMouseUp()
    {
        StartCamera.gameObject.SetActive(!StartCamera.gameObject.activeSelf);
        MainCamera.gameObject.SetActive(!MainCamera.gameObject.activeSelf);
        StartLight.gameObject.SetActive(!StartLight.gameObject.activeSelf);
        MainLight.gameObject.SetActive(!MainLight.gameObject.activeSelf);
        StartBackground.gameObject.SetActive(!StartBackground.gameObject.activeSelf);
        Start.gameObject.SetActive(!Start.gameObject.activeSelf);

    }
}

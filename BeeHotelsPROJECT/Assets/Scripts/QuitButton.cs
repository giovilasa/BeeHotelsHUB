using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{

    public Camera MainCamera;
    public Light MainLight;
    public Camera StartCamera;
    public Light StartLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnButtonClick()
    {
        StartCamera.gameObject.SetActive(!StartCamera.gameObject.activeSelf);
        MainCamera.gameObject.SetActive(!MainCamera.gameObject.activeSelf);
        StartLight.gameObject.SetActive(!StartLight.gameObject.activeSelf);
        MainLight.gameObject.SetActive(!MainLight.gameObject.activeSelf);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

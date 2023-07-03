using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnButton : MonoBehaviour
{
    public GameObject CurrUI;
    public GameObject BackUI;
    private bool isBackUIVisible = false;
    private bool isCurrUIVisible = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnButtonClick()
    {
        isBackUIVisible = !isBackUIVisible; // 
        BackUI.SetActive(isBackUIVisible); // 
        isCurrUIVisible = !isCurrUIVisible; // 
        CurrUI.SetActive(isCurrUIVisible); // 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

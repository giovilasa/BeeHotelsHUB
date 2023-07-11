using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBeeManager : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;

    public GameObject NewCard1;
    public GameObject NewCard2;
    public GameObject NewCard3;
    public GameObject NewCard4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void OnButtonClick()
    {
        if (Card1.activeSelf)
        {
            Card1.gameObject.SetActive(false);
            NewCard1.gameObject.SetActive(true);
        }

        else if (Card2.activeSelf)
        {
            Card2.gameObject.SetActive(false);
            NewCard2.gameObject.SetActive(true);
        }

        else if (Card3.activeSelf)
        {
            Card3.gameObject.SetActive(false);
            NewCard3.gameObject.SetActive(true);
        }

        else if (Card4.activeSelf)
        {
            Card4.gameObject.SetActive(false);
            NewCard4.gameObject.SetActive(true);
        }
    }
}


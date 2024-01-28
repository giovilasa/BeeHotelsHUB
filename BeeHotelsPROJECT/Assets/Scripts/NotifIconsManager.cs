using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotifIconsManager : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;

    public Button Hotel1Button;
    public Button Hotel2Button;
    public Button Hotel3Button;
    public Button Hotel4Button;

    public AudioSource buttonClickAudioSource;


    // Start is called before the first frame update
    void Start()
    {
        // Add button click listeners
        Hotel1Button.onClick.AddListener(() => ShowPanel(Panel1));
        Hotel2Button.onClick.AddListener(() => ShowPanel(Panel2));
        Hotel3Button.onClick.AddListener(() => ShowPanel(Panel3));
        Hotel4Button.onClick.AddListener(() => ShowPanel(Panel4));
    }

    public void ShowPanel(GameObject PanelToShow)
    {
        Panel1.SetActive(PanelToShow == Panel1);
        Panel2.SetActive(PanelToShow == Panel2);
        Panel3.SetActive(PanelToShow == Panel3);
        Panel4.SetActive(PanelToShow == Panel4);
        buttonClickAudioSource.Play();
    }
}

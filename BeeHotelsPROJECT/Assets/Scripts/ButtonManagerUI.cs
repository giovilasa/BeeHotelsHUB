using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManagerUI : MonoBehaviour
{
    public GameObject bomboCard;
    public GameObject cardatriceCard;
    public GameObject muratriceCard;
    public GameObject tagliafoglieCard;

    public Button showAllButton;
    public Button bomboButton;
    public Button cardatriceButton;
    public Button muratriceButton;
    public Button tagliafoglieButton;

    public AudioSource buttonClickAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        // Add button click listeners
        showAllButton.onClick.AddListener(() => ShowCard(bomboCard, true));
        bomboButton.onClick.AddListener(() => ShowCard(bomboCard));
        cardatriceButton.onClick.AddListener(() => ShowCard(cardatriceCard));
        muratriceButton.onClick.AddListener(() => ShowCard(muratriceCard));
        tagliafoglieButton.onClick.AddListener(() => ShowCard(tagliafoglieCard));
    }

    public void ShowCard(GameObject cardToShow, bool showAll = false)
    {
        bomboCard.SetActive(showAll || cardToShow == bomboCard);
        cardatriceCard.SetActive(showAll || cardToShow == cardatriceCard);
        muratriceCard.SetActive(showAll || cardToShow == muratriceCard);
        tagliafoglieCard.SetActive(showAll || cardToShow == tagliafoglieCard);
        buttonClickAudioSource.Play();
    }


}

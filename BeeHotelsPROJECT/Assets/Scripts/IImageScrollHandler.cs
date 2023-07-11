using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IImageScrollHandler : MonoBehaviour
{
    public Scrollbar scrollbar;
    public GameObject[] images;

    private int imageCount;

    private void Start()
    {
        imageCount = images.Length;
        scrollbar.onValueChanged.AddListener(OnScrollValueChanged);
    }

    public void OnScrollValueChanged(float scrollValue)
    {
        int imageIndex = Mathf.FloorToInt(scrollValue * (imageCount - 1));
        SetActiveImage(imageIndex);
    }

    private void SetActiveImage(int imageIndex)
    {
        for (int i = 0; i < imageCount; i++)
        {
            images[i].SetActive(i == imageIndex);
        }
    }

}


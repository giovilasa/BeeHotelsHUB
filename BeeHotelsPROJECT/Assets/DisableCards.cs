using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCards : MonoBehaviour
{
    public GameObject reinforcement1;
    public GameObject reinforcement2;
    public GameObject reinforcement3;
    public GameObject reinforcement4;
    public GameObject reinforcement5;
    public GameObject reinforcement6;
    public GameObject reinforcement7;

    
    public void OnMouseDown()
    {
        reinforcement1.SetActive(false);
        reinforcement2.SetActive(false);
        reinforcement3.SetActive(false);
        reinforcement4.SetActive(false);
        reinforcement5.SetActive(false);
        reinforcement6.SetActive(false);
        reinforcement7.SetActive(false);
    }
}

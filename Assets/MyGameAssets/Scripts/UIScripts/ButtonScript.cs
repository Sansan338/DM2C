using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField]
    private GameObject hard;

    void Start()
    {
        hard.SetActive(false);
    }

    public void ShowHard()
    {
        hard.SetActive(true);
    }

    public void DeleteHard()
    {
        hard.SetActive(false);
    }
}

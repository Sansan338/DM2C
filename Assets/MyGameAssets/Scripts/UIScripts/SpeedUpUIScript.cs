using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpUIScript : MonoBehaviour
{
    [SerializeField]
    private GameObject speedUpUI;

    void Start()
    {
        speedUpUI.SetActive(false);
    }

    public void OnEnd()
    {
        speedUpUI.SetActive(false);
    }

    public void ShowSpeedUpUI()
    {
        speedUpUI.SetActive(true);
    }
}

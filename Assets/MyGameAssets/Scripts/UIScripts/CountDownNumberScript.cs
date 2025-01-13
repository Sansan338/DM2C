using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownNumberScript : MonoBehaviour
{
    private float countDownTime;
    [SerializeField]
    private Text countDownText;

    [SerializeField]
    private GameObject number;
    [SerializeField]
    private GameObject backGround;

    private void Start()
    {
        number.SetActive(true);
        backGround.SetActive(true);
    }

    private void Update()
    {
        countDownTime = GameManager.gameManager.GetCurrentTimeCount();

        countDownText.text = countDownTime.ToString("f0");  

        if(GameManager.gameManager.GetGameState() == GameManager.GameState.Play)
        {
            number.SetActive(false);
            backGround.SetActive(false);
        }
    }
}

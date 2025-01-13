using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverUI;
    [SerializeField]
    private GameObject resultUI;

    void Start()
    {
        gameOverUI.SetActive(false);
        resultUI.SetActive(false);
    }

    void Update()
    {
        if(GameManager.gameManager.GetGameState() == GameManager.GameState.GameOver)
        {
            gameOverUI.SetActive(true);
            resultUI.SetActive(true);
        }
    }
}

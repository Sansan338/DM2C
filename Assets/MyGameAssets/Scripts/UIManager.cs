using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverUI;

    void Start()
    {
        gameOverUI.SetActive(false);
    }

    void Update()
    {
        if(GameManager.gameManager.GetGameState() == GameManager.GameState.GameOver)
        {
            gameOverUI.SetActive(true);
        }
    }
}

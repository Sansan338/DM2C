using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAnswerUI : MonoBehaviour
{
    [SerializeField]
    private Text playerAnswerText;

    [SerializeField]
    private PlayerAnswer playerAnswer;

    private void Start()
    {
        this.gameObject.SetActive(true);
    }

    void Update()
    {
        playerAnswerText.text = playerAnswer.GetPlayerInput().ToString();

        if(GameManager.gameManager.GetGameState() == GameManager.GameState.GameOver)
        {
            this.gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    private int score;

    void Update()
    {
        score = GameManager.gameManager.GetCorrectCount();
        scoreText.text = score.ToString();
    }
}

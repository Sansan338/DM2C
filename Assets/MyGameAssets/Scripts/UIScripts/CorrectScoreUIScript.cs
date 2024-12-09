using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorrectScoreUIScript : MonoBehaviour
{
    [SerializeField]
    private Text correctCountText;

    private int correctCount;

    void Update()
    {
        correctCount = GameManager.gameManager.GetCorrectCount();
        correctCountText.text = correctCount.ToString();
    }
}

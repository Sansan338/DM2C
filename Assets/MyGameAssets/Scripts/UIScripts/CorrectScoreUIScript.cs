using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorrectScoreUIScript : MonoBehaviour
{
    [SerializeField]
    private NumberWallScript numberWallScript;
    [SerializeField]
    private Text correctCountText;

    private int correctCount;

    void Update()
    {
        correctCount = numberWallScript.GetCorrectCount();
        correctCountText.text = correctCount.ToString();
    }
}

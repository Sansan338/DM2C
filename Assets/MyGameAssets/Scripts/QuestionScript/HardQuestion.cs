using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HardQuestion : MonoBehaviour
{
    private PlayerAnswer playerAnswerScript;

    [SerializeField]
    private TextMeshPro firstText;
    [SerializeField]
    private TextMeshPro secondText;
    [SerializeField]
    private TextMeshPro symbolText;
    [SerializeField]
    private TextMeshPro answerText;

    private int number;
    private float firstNumber;
    private float secondNumber;

    private float answer;
    private float playerAnswer;

    private int[] symbolNumber = { 1, 2, 3, 4 };     //1 = "+"  2 = "-"  3 = "*"  4 = "/"
    private int symbol;

    private int playerSelection;

    private bool isTrue;

    void Start()
    {
        //ç≈èâÇÕñ‚ëËÇ™ä»íPÇ…Ç»ÇÈÇÊÇ§Ç…ÅAêîéöÇÃç≈ëÂílÇ10Ç…Ç∑ÇÈ
        number = 20;

        playerSelection = 0;
        playerAnswerScript = GameObject.Find("PlayerAnswerInput").GetComponent<PlayerAnswer>();
        ChooseFirstNumber();
        ChooseSecondNumber();
        ChooseSymbol();
        Calculation();
    }

    void Update()
    {
        playerAnswer = playerAnswerScript.GetPlayerInput();

        if (playerAnswer == answer)
        {
            isTrue = true;
        }
        else
        {
            isTrue = false;
        }
    }

    public void ChooseFirstNumber()
    {
        firstNumber = Random.Range(0, number + 1);
        firstText.text = firstNumber.ToString();
    }

    public void ChooseSecondNumber()
    {
        secondNumber = Random.Range(1, number + 1);
        secondText.text = secondNumber.ToString();
    }

    public void ChooseSymbol()
    {
        symbol = Random.Range(1, symbolNumber.Length + 1);

        if (symbol == 1)
        {
            symbolText.text = "Å{";
        }
        else if (symbol == 2)
        {
            symbolText.text = "Å|";
        }
        else if (symbol == 3)
        {
            symbolText.text = "Å~";
        }
        else if (symbol == 4)
        {
            symbolText.text = "ÅÄ";
        }
    }

    public float Calculation()
    {
        if (symbol == 4)
        {
            answer = firstNumber / secondNumber;
        }
        else if (symbol == 1)
        {
            answer = firstNumber + secondNumber;
        }
        else if (symbol == 2)
        {
            answer = firstNumber - secondNumber;
        }
        else if (symbol == 3)
        {
            answer = firstNumber * secondNumber;
        }

        if ((int)answer == answer)
        {
            answerText.text = "Å†";
        }
        else if ((int)answer != answer)
        {
            ChooseFirstNumber();
            ChooseSecondNumber();
            ChooseSymbol();
            Calculation();
        }

        return answer;
    }

    public bool GetIsTrue()
    {
        return isTrue;
    }
}

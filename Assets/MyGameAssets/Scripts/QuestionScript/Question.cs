using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Question : MonoBehaviour
{
    private ChooseSymbolButton chooseSymbolScript;

    [SerializeField]
    private TextMeshPro firstText;
    [SerializeField]
    private TextMeshPro secondText;
    [SerializeField]
    private TextMeshPro symbolText;
    [SerializeField]
    private TextMeshPro answerText;

    private float number;
    private float firstNumber;
    private float secondNumber;

    private float answer;
    private float playerAnswer;

    private int[] symbolNumber = {1,2,3,4};     //1 = "+"  2 = "-"  3 = "*"  4 = "/"
    private int symbol;

    private int playerSelection;

    private bool isTrue;

    void Start()
    {
        //最初は問題が簡単になるように、数字の最大値を10にする
        number = 10;

        playerSelection = 0;
        chooseSymbolScript = GameObject.Find("Button").GetComponent<ChooseSymbolButton>();
        ChooseFirstNumber();
        ChooseSecondNumber();
        ChooseSymbol();
        Calculation();
    }

    void Update()
    {
        PlayerCalculation();

        if (chooseSymbolScript != null)
        {
            playerSelection = chooseSymbolScript.GetPlayerChoose();
        }

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
    }

    public float Calculation()
    {
        if (symbol == 1)
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
        else if (symbol == 4)
        {
            answer = firstNumber / secondNumber;
        }

        Debug.Log ("答え"+answer);
        Debug.Log ("四則演算"+symbol);

        answerText.text = answer.ToString();

        return answer;
    }

    public float PlayerCalculation()
    {
        if (chooseSymbolScript.GetPlayerChoose() == 1)
        {
            playerAnswer = firstNumber + secondNumber;
        }
        else if (chooseSymbolScript.GetPlayerChoose() == 2)
        {
            playerAnswer = firstNumber - secondNumber;
        }
        else if (chooseSymbolScript.GetPlayerChoose() == 3)
        {
            playerAnswer = firstNumber * secondNumber;
        }
        else if (chooseSymbolScript.GetPlayerChoose() == 4)
        {
            playerAnswer = firstNumber / secondNumber;
        }

        return playerAnswer;
    }

    public bool GetIsTrue()
    {
        return isTrue;
    }
}

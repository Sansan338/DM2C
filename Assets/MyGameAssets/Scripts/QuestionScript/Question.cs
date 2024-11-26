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

    private int firstNumber;
    private int secondNumber;

    private float answer;

    private int[] symbolNumber = {1,2,3,4};     //1 = "+"  2 = "-"  3 = "*"  4 = "/"
    private int symbol;

    private int playerSelection;

    private bool isTrue;

    void Start()
    {
        chooseSymbolScript = GetComponent<ChooseSymbolButton>();
        ChooseFirstNumber();
        ChooseSecondNumber();
        ChooseSymbol();
        Calculation();
    }

    void Update()
    {
        if (chooseSymbolScript != null)
        {
            playerSelection = chooseSymbolScript.GetChooseAnswer();
        }

        if (playerSelection == symbol)
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
        firstNumber = Random.Range(0, 100);
        firstText.text = firstNumber.ToString();
    }

    public void ChooseSecondNumber()
    {
        secondNumber = Random.Range(0, 100);
        secondText.text = secondNumber.ToString();
    }

    public void ChooseSymbol()
    {
        symbol = Random.Range(0, symbolNumber.Length - 1);
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

        answerText.text = answer.ToString();

        return answer;
    }

    public bool GetIsTrue()
    {
        return isTrue;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSymbolButton : MonoBehaviour
{
    private int playerAnswer;

    public void ChoosePlus()
    { playerAnswer = 1; }

    public void ChooseMinus()
    { playerAnswer = 2; }

    public void ChooseMultiplied()
    { playerAnswer = 3; }

    public void ChooseDivided()
    { playerAnswer = 4; }

    public int GetChooseAnswer()
    { return playerAnswer; }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSymbolButton : MonoBehaviour
{
    private int playerChoose;

    public void ChoosePlus()
    {
        playerChoose = 1;
    }

    public void ChooseMinus()
    {
        playerChoose = 2;
    }

    public void ChooseMultiplied()
    { 
        playerChoose = 3;
    }

    public void ChooseDivided()
    {
        playerChoose = 4;
    }
    public int GetPlayerChoose()
    {
        return playerChoose;
    }
}

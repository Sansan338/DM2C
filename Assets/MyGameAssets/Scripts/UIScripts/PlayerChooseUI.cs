using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerChooseUI : MonoBehaviour
{
    [SerializeField]
    ChooseSymbolButton chooseSymbolScript;

    [SerializeField]
    private Text chooseText;

    private int playerChoose;

    void Start()
    {
        
    }

    void Update()
    {
        playerChoose = chooseSymbolScript.GetPlayerChoose();
        
        if(playerChoose == 1)
        {
            chooseText.text = "+";
        }
        else if (playerChoose == 2)
        {
            chooseText.text = "-";
        }
        else if (playerChoose == 3)
        {
            chooseText.text = "Å~";
        }
        else if (playerChoose == 4)
        {
            chooseText.text = "ÅÄ";
        }
    }
}

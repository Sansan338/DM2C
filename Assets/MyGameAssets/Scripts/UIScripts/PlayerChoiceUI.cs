using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerChoiceUI : MonoBehaviour
{
    [SerializeField]
    private ChooseSymbolButton chooseSymboButton;
    [SerializeField]
    private Text chooseSymbolText;

    private int chooseSymbol;

    void Start()
    {
        
    }

    void Update()
    {
        chooseSymbol = chooseSymboButton.GetPlayerChoose();

        if (chooseSymbol == 0)
        {
            chooseSymbolText.text = " ";
        }
        else if (chooseSymbol == 1)
        {
            chooseSymbolText.text = "+";
        }
        else if (chooseSymbol == 2)
        {
            chooseSymbolText.text = "Å|";
        }
        else if (chooseSymbol == 3)
        {
            chooseSymbolText.text = "Å~";
        }
        else if (chooseSymbol == 4)
        {
            chooseSymbolText.text = "ÅÄ";
        }
    }
}

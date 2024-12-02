using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectUI : MonoBehaviour
{
    private NumberWallScript numberWallScript;

    private GameObject wall;

    void Update()
    {
        if(numberWallScript.GetWasCorrect() == true)
        {
            this.gameObject.SetActive(true);
        }
    }

    public void OnAnimationEnd()
    {
        this.gameObject.SetActive(false);
        numberWallScript.SetWasCorrect();
    }
}

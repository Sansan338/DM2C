using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    void Start()
    {
        this.gameObject.SetActive(true);
    }

    
    void Update()
    {
        if(GameManager.gameManager.GetGameState() == GameManager.GameState.GameOver)
        {
            this.gameObject.SetActive(false);
        }
    }
}

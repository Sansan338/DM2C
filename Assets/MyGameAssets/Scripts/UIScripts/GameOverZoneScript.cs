using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverZoneScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            GameManager.gameManager.SetGameState(GameManager.GameState.GameOver);
        }
    }
}

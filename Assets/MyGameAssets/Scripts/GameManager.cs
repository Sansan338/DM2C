using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        Play,
        Pause,
        GameOver,
        Result
    }

    private GameState currentGameState;

    public static GameManager gameManager;

    void Start()
    {
        gameManager = this;
        Application.targetFrameRate = 60;
        SetGameState(GameState.Play);
    }

    void Update()
    {

    }

    public GameState GetGameState()
    {
        return currentGameState;
    }

    public void SetGameState(GameState gameState)
    {
        currentGameState = gameState;
    }
}

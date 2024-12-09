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

    private int correctCount;


    public static GameManager gameManager;

    void Start()
    {
        gameManager = this;
        Application.targetFrameRate = 60;
        SetGameState(GameState.Play);

        correctCount = 0;
    }

    void Update()
    {

    }

    public void PlusCorrectCount()
    {
        correctCount++;
    }

    public int GetCorrectCount()
    {
        return correctCount;
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

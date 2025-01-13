using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        Ready,
        Play,
        Pause,
        GameOver,
        Result
    }

    private GameState currentGameState;

    private float currentTimeCount = 3.0f;

    private int correctCount;

    public static GameManager gameManager;

    void Start()
    {
        Application.targetFrameRate = 60;

        SetGameState(GameState.Ready);

        gameManager = this;
        correctCount = 0;
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

    public float GetCurrentTimeCount()
    {
        return currentTimeCount;
    }
}

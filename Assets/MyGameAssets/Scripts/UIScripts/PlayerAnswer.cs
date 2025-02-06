using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAnswer : MonoBehaviour
{
    [SerializeField]
    private InputField playerInputField;

    [SerializeField]
    private GameObject playerInput;

    private string playerText;

    private int playerAnswer;

    private void Start()
    {
        playerInputField.ActivateInputField();
    }

    public void PlayerInput()
    {
        playerText = playerInput.GetComponent<InputField>().text;
        playerAnswer = int.Parse(playerText);
        playerInputField.ActivateInputField();
    }

    public int GetPlayerInput()
    {
        return playerAnswer;
    }
}

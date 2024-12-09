using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CorrectUI : MonoBehaviour
{
    [SerializeField]
    private PlayerScript playerScript;
    [SerializeField]
    private Animator correctAnimator;

    void Start()
    {
        correctAnimator.SetBool("isCorrect",false);
    }

    void Update()
    {
        if(playerScript.GetIsCorrect() == true)
        {
            correctAnimator.SetBool("isCorrect", true);
        }
    }

    public void OnAnimationEnd()
    {
        correctAnimator.SetBool("isCorrect", false);
        playerScript.ResetIsCorrect();
    }
}

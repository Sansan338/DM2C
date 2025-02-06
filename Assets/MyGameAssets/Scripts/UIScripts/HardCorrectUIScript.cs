using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCorrectUIScript : MonoBehaviour
{
    [SerializeField]
    private HardPlayer hardPlayerScript;
    [SerializeField]
    private Animator correctAnimator;

    void Start()
    {
        correctAnimator.SetBool("isCorrect", false);
    }

    void Update()
    {
        if (hardPlayerScript.GetIsCorrect() == true)
        {
            correctAnimator.SetBool("isCorrect", true);
        }
    }

    public void OnAnimationEnd()
    {
        correctAnimator.SetBool("isCorrect", false);
        hardPlayerScript.ResetIsCorrect();
    }
}

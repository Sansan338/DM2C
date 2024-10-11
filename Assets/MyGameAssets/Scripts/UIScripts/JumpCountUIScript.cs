using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JumpCountUIScript : MonoBehaviour
{
    [SerializeField]
    private Text jumpCountText;
    [SerializeField]
    private PlayerScript playerScript;

    private int jumpCount;

    void Update()
    {
        jumpCount = playerScript.GetJumpCount();
        jumpCountText.text = jumpCount.ToString();
    }
}

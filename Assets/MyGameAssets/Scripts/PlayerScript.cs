using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private Rigidbody playerRigidbody;
    [SerializeField]
    private Animator playerAnimator;
    [SerializeField]
    private float moveSpeed;

    void Start()
    {
        playerAnimator.SetBool("isMove",false);
    }

    void Update()
    {
        playerAnimator.SetFloat("MoveSpeed",moveSpeed);

        var moveX = Input.GetAxis("Horizontal");

        if(moveX != 0)
        {
            playerAnimator.SetBool("isMove", true);
        }
        else
        {
            playerAnimator.SetBool("isMove",false);
        }

        playerRigidbody.velocity = new Vector3(moveX * moveSpeed * Time.deltaTime, playerRigidbody.velocity.y,0);
    }
}

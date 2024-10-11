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
    [SerializeField]
    private float jumpPower;
    [SerializeField]
    private int maxJump;

    private int currentJumpCount;

    private bool isGround;

    void Start()
    {
        playerAnimator.SetBool("isMove",false);
        currentJumpCount = maxJump;
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

        if(Input.GetKeyDown(KeyCode.Space) && isGround == true && currentJumpCount > 0)
        {
            playerRigidbody.velocity = Vector3.up * jumpPower;
            currentJumpCount--;
        }

        playerRigidbody.velocity = new Vector3(moveX * moveSpeed * Time.deltaTime, playerRigidbody.velocity.y,0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            GameManager.gameManager.SetGameState(GameManager.GameState.GameOver);
        }

        if(collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGround = false;
        }
    }

    //ƒWƒƒƒ“ƒv‰ñ”‚ğæ“¾
    public int GetJumpCount()
    {
        return currentJumpCount;
    }
}

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
        currentJumpCount = maxJump;
    }

    void Update()
    {
        playerAnimator.SetFloat("MoveSpeed",moveSpeed);

        var moveX = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.Space) && isGround == true && currentJumpCount > 0)
        {
            playerAnimator.SetBool("isJump",true);
            playerRigidbody.velocity = Vector3.up * jumpPower;
            isGround = false;
            currentJumpCount--;
        }

        if(playerRigidbody.velocity.y < 0 && isGround == false)
        {
            playerAnimator.SetBool("isJump", false);
            playerAnimator.SetBool("isFall", true);
        }

        if(isGround == true)
        {
            playerAnimator.SetBool("isFall",false);
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

    public void OnJump()
    {
        if (isGround == true && currentJumpCount > 0)
        {
            playerAnimator.SetBool("isJump", true);
            playerRigidbody.velocity = Vector3.up * jumpPower;
            isGround = false;
            currentJumpCount--;
        }
    }

    //ƒWƒƒƒ“ƒv‰ñ”‚ğæ“¾
    public int GetJumpCount()
    {
        return currentJumpCount;
    }
}

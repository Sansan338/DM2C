using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private LevelMove levelMove;

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

    [SerializeField]
    private int acceleration;
    [SerializeField]
    private int accelerationFrequency;

    private int currentJumpCount;

    private bool isGround;
    private bool isCorrect;

    void Start()
    {
        isCorrect = false;
        currentJumpCount = maxJump;
        moveSpeed = 0;
        playerAnimator.SetBool("isMove",true);
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
            isCorrect = false;
            GameManager.gameManager.SetGameState(GameManager.GameState.GameOver);
        }

        if(collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Wall")
        {
            isCorrect = true;
            VariableMoveSpeed();
        }
    }

    private void VariableMoveSpeed()
    {
        if(GameManager.gameManager.GetCorrectCount() % accelerationFrequency == 0)
        {
            moveSpeed += acceleration;
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

    //ジャンプ回数を取得
    public int GetJumpCount()
    {
        return currentJumpCount;
    }

    //正解かどうかを取得
    public bool GetIsCorrect()
    {
        return isCorrect;
    }

    //リセット
    public void ResetIsCorrect()
    {
        isCorrect = false;
    }
}

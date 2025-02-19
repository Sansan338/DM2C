using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalNumberWallScript : MonoBehaviour
{
    [SerializeField]
    private NormalQuestion normalQuestion;

    [SerializeField]
    private Collider wallCollider;

    private void Update()
    {
        if (GameManager.gameManager.GetGameState() != GameManager.GameState.GameOver)
        {
            this.gameObject.transform.position -= new Vector3(0, 0, GameManager.gameManager.GetLevelMoveSpeed() * Time.deltaTime);
        }


            //正解の時は壁を抜けられる

            if (normalQuestion.GetIsTrue() == true)
        {
            wallCollider.isTrigger = true;
        }
        else if (normalQuestion.GetIsTrue() == false)
        {
            wallCollider.isTrigger = false;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);

            GameManager.gameManager.PlusCorrectCount();

            GameManager.gameManager.SpeedUp();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardNumberWallScript : MonoBehaviour
{
    [SerializeField]
    private HardQuestion hardQuestion;

    [SerializeField]
    private Collider wallCollider;

    private void Update()
    {
        if (GameManager.gameManager.GetGameState() != GameManager.GameState.GameOver)
        {
            this.gameObject.transform.position -= new Vector3(0, 0, GameManager.gameManager.GetLevelMoveSpeed() * Time.deltaTime);
        }


        //�����̎��͕ǂ𔲂�����

        if (hardQuestion.GetIsTrue() == true)
        {
            wallCollider.isTrigger = true;
        }
        else if (hardQuestion.GetIsTrue() == false)
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

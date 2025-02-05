using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWallScript : MonoBehaviour
{
    [SerializeField]
    private Question question;

    [SerializeField]
    private Collider wallCollider;

    [SerializeField]
    private float movePower;
    [SerializeField]
    private float moveSpeed;

    private void Update()
    {
        //�ǂ̈ړ�
        //wallRigidbody.AddForce(Vector3.back * ((moveSpeed + wallRigidbody.velocity.z) * movePower), ForceMode.Acceleration);

        this.gameObject.transform.position -= new Vector3(0, 0, GameManager.gameManager.GetLevelMoveSpeed() * Time.deltaTime);


        //�����̎��͕ǂ𔲂�����

        if (question.GetIsTrue() == true)
        {
            wallCollider.isTrigger = true;
        }
        else if (question.GetIsTrue() == false)
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWallScript : MonoBehaviour
{
    [SerializeField]
    private Question question;

    [SerializeField]
    private Rigidbody wallRigidbody;
    [SerializeField]
    private Collider wallCollider;
    [SerializeField]
    private GameObject brokenWall;

    [SerializeField]
    private float movePower;
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float destroyTime;

    private void Update()
    {
        //壁の移動
        //wallRigidbody.AddForce(Vector3.back * ((moveSpeed + wallRigidbody.velocity.z) * movePower), ForceMode.Acceleration);
        wallRigidbody.velocity = new Vector3(0, 0, -moveSpeed);

        //正解の時は壁を抜けられる
        if (question != null)
        {
            if (question.GetIsTrue() == true)
            {
                wallCollider.isTrigger = true;
            }
            else if (question.GetIsTrue() == false)
            {
                wallCollider.isTrigger = false;
            }
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            var unnecessaryWall = Instantiate(brokenWall, new Vector3(wallCollider.transform.position.x, 0, wallCollider.transform.position.z), this.transform.rotation);

            Destroy(this.gameObject);

            GameManager.gameManager.PlusCorrectCount();

            Destroy(unnecessaryWall, destroyTime);
        }
    }
}

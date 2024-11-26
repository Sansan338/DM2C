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

    private int correctCount;

    void Start()
    {
        correctCount = 0;
    }

    private void FixedUpdate()
    {
        wallRigidbody.AddForce(Vector3.back * ((moveSpeed + wallRigidbody.velocity.z) * movePower), ForceMode.Acceleration);
    }

    private void Update()
    {
        //ê≥âÇÃéûÇÕï«Çî≤ÇØÇÁÇÍÇÈ
        if(question.GetIsTrue() == true)
        {
            wallCollider.isTrigger = true;
        }
        else if(question.GetIsTrue() == false)
        {
            wallCollider.isTrigger = false;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            var unnecessaryWall = Instantiate(brokenWall,new Vector3(wallCollider.transform.position.x,0,wallCollider.transform.position.z),this.transform.rotation);

            correctCount++;

            Destroy(unnecessaryWall, destroyTime);
        }
    }

    public int GetCorrectCount()
    {
        return correctCount;
    }
}

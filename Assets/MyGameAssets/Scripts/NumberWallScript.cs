using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWallScript : MonoBehaviour
{
    [SerializeField]
    private Rigidbody wallRigidbody;
    [SerializeField]
    private Collider wallCollider;
    [SerializeField]
    private GameObject brokenWall;

    [SerializeField]
    private float startPositionZ;
    [SerializeField]
    private float endPositionZ;
    [SerializeField]
    private float movePower;
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float destroyTime;

    private bool isCorrect;

    private int correctCount;

    void Start()
    {
        correctCount = 0;
        this.transform.position = new Vector3 (this.transform.position.x,this.transform.position.y,startPositionZ);
    }

    private void FixedUpdate()
    {
        if (this.transform.position.z > endPositionZ)
        {
            wallRigidbody.AddForce(Vector3.back * ((moveSpeed + wallRigidbody.velocity.z) * movePower), ForceMode.Acceleration);
        }
        else if (this.transform.position.z <= endPositionZ)
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, startPositionZ);
        }
    }

    private void Update()
    {
        //�����̎��͕ǂ𔲂�����
        if(isCorrect == true)
        {
            wallCollider.isTrigger = true;
        }
        else if(isCorrect == false)
        {
            wallCollider.isTrigger = false;
        }

        //����s�����̊m�F�p
        if(Input.GetMouseButtonDown(0))
        {
            if(isCorrect == true)
            {
                wallCollider.isTrigger = false;
                Debug.Log("���̖��͕s�����ł�");
                isCorrect = false;
            }
            else if(isCorrect == false)
            {
                wallCollider.isTrigger = true;
                Debug.Log("���̖��͐����ł�");
                isCorrect = true;
            }
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWallScript : MonoBehaviour
{
    [SerializeField]
    private Rigidbody wallRigidbody;
    [SerializeField]
    private float startPositionZ;
    [SerializeField]
    private float endPositionZ;
    [SerializeField]
    private float movePower;
    [SerializeField]
    private float moveSpeed;

    void Start()
    {
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
}

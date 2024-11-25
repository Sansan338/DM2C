using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMove : MonoBehaviour
{
    [SerializeField]
    private float levelMoveSpeed;

    private void FixedUpdate()
    {
        this.gameObject.transform.position -= new Vector3(0,0,levelMoveSpeed *  Time.deltaTime);
    }
}

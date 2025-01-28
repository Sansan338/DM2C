using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMove : MonoBehaviour
{
    private void FixedUpdate()
    {
        this.gameObject.transform.position -= new Vector3(0,0,GameManager.gameManager.GetLevelMoveSpeed() *  Time.deltaTime);
    }
}

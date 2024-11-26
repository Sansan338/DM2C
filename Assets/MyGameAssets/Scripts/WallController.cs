using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    [SerializeField]
    private GameObject wallPrefab;
    [SerializeField]
    private float startPositionZ;
    [SerializeField]
    private float endPositionZ;

    private GameObject wall;

    void Start()
    {
        Instantiate(wallPrefab, new Vector3(0,wallPrefab.transform.position.y,startPositionZ),Quaternion.identity);
    }
}

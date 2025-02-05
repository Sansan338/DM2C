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

    private bool isWall;

    void Start()
    {
        wall = Instantiate(wallPrefab, new Vector3(0,wallPrefab.transform.position.y,startPositionZ),Quaternion.identity);
        isWall = false;
    }

    void Update()
    {
        if(wall == null || wall.transform.position.z <= endPositionZ)
        {
            Destroy(wall);
            wall = Instantiate(wallPrefab, new Vector3(0, wallPrefab.transform.position.y, startPositionZ), Quaternion.identity);
            isWall = true;
        }
    }

    public bool GetIsWall()
    {
        return isWall;
    }

    public void SetIsWall()
    {
        isWall = false;
    }
}

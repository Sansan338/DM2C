using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevels : MonoBehaviour
{
    [SerializeField]
    private GameObject[] level;

    [SerializeField]
    private float generateTime;

    [SerializeField]
    private float zPosition;

    private int levelCount;

    private bool creatingLevel;

    private int levelNumber;


    void Start()
    {
        creatingLevel = false;
    }

    void Update()
    {
        if (!creatingLevel)
        {
            creatingLevel = true;
            StartCoroutine(GenerateLevel());
        }
    }

    IEnumerator GenerateLevel()
    {
        levelNumber = Random.Range(0, level.Length);
        Instantiate(level[levelNumber], new Vector3(0, 0, zPosition), Quaternion.identity);
        yield return new WaitForSeconds(generateTime);
        creatingLevel = false;
    }
}

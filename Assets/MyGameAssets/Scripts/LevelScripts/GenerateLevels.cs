using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevels : MonoBehaviour
{
    [SerializeField]
    private LevelDestroyer levelDestroyerScript;

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
        levelCount = GameObject.FindGameObjectsWithTag("Level").Length;
    }

    void Update()
    {
        if (!creatingLevel)
        {
            creatingLevel = true;
            //StartCoroutine(GenerateLevel());
        }

        if(levelDestroyerScript.GetIsDestroy() == true)
        {
            levelNumber = Random.Range(0, level.Length);
            Instantiate(level[levelNumber],new Vector3(0,0,zPosition),Quaternion.identity);
            levelDestroyerScript.SetFalseIsDestroy();
        }
    }

    //現在は時間ごとに生成されているので、生成されている数が常に一定になるように改善が必要
    //最後に生成されたレベルを取得し、そのレベルが一定の位置まで進むと次のレベルが出現するようにする？
    IEnumerator GenerateLevel()
    {
        levelNumber = Random.Range(0, level.Length);
        Instantiate(level[levelNumber], new Vector3(0, 0, zPosition), Quaternion.identity);
        yield return new WaitForSeconds(generateTime);
        creatingLevel = false;
    }
}

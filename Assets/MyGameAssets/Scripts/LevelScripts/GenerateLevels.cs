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

    //���݂͎��Ԃ��Ƃɐ�������Ă���̂ŁA��������Ă��鐔����Ɉ��ɂȂ�悤�ɉ��P���K�v
    //�Ō�ɐ������ꂽ���x�����擾���A���̃��x�������̈ʒu�܂Ői�ނƎ��̃��x�����o������悤�ɂ���H
    IEnumerator GenerateLevel()
    {
        levelNumber = Random.Range(0, level.Length);
        Instantiate(level[levelNumber], new Vector3(0, 0, zPosition), Quaternion.identity);
        yield return new WaitForSeconds(generateTime);
        creatingLevel = false;
    }
}

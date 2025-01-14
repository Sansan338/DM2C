using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDestroyer : MonoBehaviour
{
    [SerializeField]
    private GenerateLevels generateLevels;

    private bool isDestroy;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Level")
        {
            Destroy(collider.gameObject);
            isDestroy = true;
        }
    }

    public bool GetIsDestroy()
    {
        return isDestroy;
    }

    public void SetFalseIsDestroy()
    {
        isDestroy = false;
    }
}

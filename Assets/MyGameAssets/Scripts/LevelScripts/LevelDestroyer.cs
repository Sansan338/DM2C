using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDestroyer : MonoBehaviour
{
    [SerializeField]
    private GenerateLevels generateLevels;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Level")
        {
            Destroy(collider.gameObject);
        }
    }
}

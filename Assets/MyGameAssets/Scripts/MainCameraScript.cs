using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    void Update()
    {
        if (player != null)
        {
            this.gameObject.transform.position = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z - 5);
        }
    }
}

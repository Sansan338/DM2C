using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    void Update()
    {
        if(player != null)
        {
            this.gameObject.transform.position = new Vector3(this.transform.position.x, 0, player.transform.position.z);
        }
    }
}

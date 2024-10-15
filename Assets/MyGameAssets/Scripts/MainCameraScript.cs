using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float delaySpeed;

    private Vector3 offset;


    void Start()
    {
        offset = this.transform.position - player.transform.position;
    }
    void Update()
    {
        if (player != null)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, player.transform.position + offset, delaySpeed * Time.deltaTime);
        }
    }
}

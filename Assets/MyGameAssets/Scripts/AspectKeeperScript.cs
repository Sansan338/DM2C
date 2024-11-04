using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AspectKeeperScript : MonoBehaviour
{
    [SerializeField]
    private Camera mainCamera;
    [SerializeField]
    private Vector2 aspectVector;

    void Update()
    {
        var screenAspect = (float)Screen.width / Screen.height;
        var targetAspect = aspectVector.x / aspectVector.y;

        var magnification = targetAspect / screenAspect;

        var viewportRect = new Rect(0, 0, 1, 1);
        viewportRect.width = magnification;
        mainCamera.rect = viewportRect;
    }
}

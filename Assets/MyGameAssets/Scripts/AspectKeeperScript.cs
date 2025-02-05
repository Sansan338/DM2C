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
        var screenAspect = Screen.width / (float)Screen.height;
        var targetAspect = aspectVector.x / aspectVector.y;

        var magnification = targetAspect / screenAspect;

        var viewportRect = new Rect(0, 0, 1, 1);

        if (magnification < 1)
        {
            viewportRect.width = magnification;
            viewportRect.x = 0.5f - viewportRect.width * 0.5f;
        }
        else
        {
            viewportRect.height = 1 / magnification;
            viewportRect.y = 0.5f - viewportRect.height * 0.5f;
        }
        mainCamera.rect = viewportRect;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollSetupScript : MonoBehaviour
{
    [SerializeField]
    private Transform rootBone;

    public void Setup(Transform originalRootBone)
    {
        CloneTransform(originalRootBone, rootBone);
    }

    private void CloneTransform(Transform root, Transform clone)
    {
        foreach(Transform child in root)
        {
            Transform cloneChild = clone.Find(child.name);
            if(cloneChild != null)
            {
                cloneChild.position = child.position;
                cloneChild.rotation = child.rotation;

                CloneTransform(child, cloneChild);
            }
        }
    }
}
